#include <stdio.h>
#include <assert.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>

#define MAX_DATA 512
#define MAX_ROWS 100

struct Address {
    int id;
    int set;
    char name[MAX_DATA];
    char email[MAX_DATA];
};

struct Database {
    struct Address rows[MAX_ROWS];
};

struct Connection {
    FILE *file;
    struct Database *db;
};

void die(const char *message)
{
    if(errno) {
        perror(message);
    } else {
        printf("ERROR: %s\n", message);
    }
    
    exit(1);
}

void dieConn(const char *message, struct Connection *conn)
{
    if(errno) {
        perror(message);
    } else {
        printf("ERROR: %s\n", message);
    }
    
    if(conn) {
        if(conn->file) fclose(conn->file);
        if(conn->db) free(conn->db);
        free(conn);
    }
    
    exit(1);
}

void Address_print(struct Address *addr)
{
    printf("%d %s %s\n",
           addr->id, addr->name, addr->email);
}

void Database_load(struct Connection *conn)
{
    int rc = fread(conn->db, sizeof(struct Database), 1, conn->file);
    if(rc != 1) dieConn("Failed to load database.", conn);
}

struct Connection *Database_open(const char *filename, char mode)
{
    struct Connection *conn = malloc(sizeof(struct Connection));
    if(!conn) dieConn("Memory error", conn);
    
    conn->db = malloc(sizeof(struct Database));
    if(!conn->db) dieConn("Memory error", conn);
    
    if (mode == 'c') {
        conn->file = fopen(filename, "w");
    } else {
        conn->file = fopen(filename, "r+");
        
        if(conn->file) {
            Database_load(conn);
        }
    }
    
    if(!conn->file) dieConn("Failed to open the file", conn);
    
    return conn;
}

void Database_close(struct Connection *conn)
{
    if(conn) {
        if(conn->file) fclose(conn->file);
        if(conn->db) free(conn->db);
        free(conn);
    }
}

void Database_write(struct Connection *conn)
{
    rewind(conn->file);
    
    int rc = fwrite(conn->db, sizeof(struct Database), 1, conn->file);
    if(rc != 1) dieConn("Failed to write database.", conn);
    
    rc = fflush(conn->file);
    if(rc == -1) dieConn("Cannot flush database.", conn);
}

void Database_create(struct Connection *conn)
{
    int i = 0;
    
    for(i = 0; i <  MAX_ROWS; i++) {
        //make a prototype to initialize it
        struct Address addr = {.id = i, .set = 0};
        //then just assign it
        conn->db->rows[i] = addr;
    }
}

void Database_set(struct Connection *conn, int id, const char *name, const char *email)
{
    struct Address *addr = &conn->db->rows[id];
    if(addr->set) dieConn("Already set, delete it first", conn);
    
    addr->set = 1;
    //WARNING: bug, read the "How to break it" and fix this
    char *res = strncpy(addr->name, name, MAX_DATA);
    //this should fix the bug
    res[strlen(res) - 1] = '\0';
    //demonstrate the strncpy bug
    if(!res) dieConn("Name copy failed", conn);
    
    res = strncpy(addr->email, email, MAX_DATA);
    res[strlen(res) - 1] = '\0';
    if(!res) dieConn("Email copy failed", conn);
}

void Database_get(struct Connection *conn, int id)
{
    struct Address *addr = &conn->db->rows[id];
    
    if(addr->set) {
        Address_print(addr);
    } else {
        dieConn("ID is not set", conn);
    }
}

void Database_delete(struct Connection *conn, int id)
{
    struct Address addr = {.id = id, .set = 0};
    conn->db->rows[id] = addr;
}

void Database_list(struct Connection *conn)
{
    int i = 0;
    struct Database *db = conn->db;
    
    for(i = 0; i < MAX_ROWS; i++) {
        struct Address *cur = &db->rows[i];
        
        if(cur->set) {
            Address_print(cur);
        }
    }
}

int main(int argc, char *argv[])
{
    if(argc < 3) die("USAGE: ex17 <dbfile> <action> [action params]");
    
    char *filename = argv[1];
    char action = argv[2][0];
    struct Connection *conn = Database_open(filename, action);
    int id = 0;
    
    if(argc > 3) id = atoi(argv[3]);
    if(id >= MAX_ROWS) dieConn("There's not that many records.", conn);
    
    switch(action) {
            case 'c':
            Database_create(conn);
            Database_write(conn);
            break;
            
            case 'g':
            if(argc != 4) dieConn("Need an id to get", conn);
            
            Database_get(conn, id);
            break;
            
            case 's':
            if(argc != 6) dieConn("Need id, name, email to set", conn);
            
            Database_set(conn, id, argv[4], argv[5]);
            Database_write(conn);
            break;
            
            case 'd':
            if (argc != 4) dieConn("Need it to delete", conn);
            
            Database_delete(conn, id);
            Database_write(conn);
            break;
            
            case 'l':
            Database_list(conn);
            break;
        default:
            dieConn("Invalid action, only: c=create, g=get, s=set, d=del, l=list", conn);
    }
    
    Database_close(conn);
    
    return 0;
}
