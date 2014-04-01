#include <iostream>
#include <fstream>

using namespace std;

static int SPACE = 32;
static int EXCLAIM = 33;
static int PERIOD = 46;
static int QUESTION = 63;

class AbstractTrans
{
protected:
    ifstream inFile;
    ofstream outFile;
public:
    AbstractTrans(char *inFileName, char *outFileName);
    ~AbstractTrans();
    //pure virtual function
    virtual char transform(char ch) const = 0;

    //do the actual work
    void transfer();
};

//constructor opens the input and output file
AbstractTrans::AbstractTrans(char *inFileName, char *outFileName) {
    inFile.open(inFileName);
    outFile.open(outFileName);

    if(!inFile)
    {
        cout << "The file " << inFileName
             << " cannot be opened.";
        exit(1);
    }
    if(!outFile)
    {
        cout << "The file " << outFileName
             << " cannot be opened.";
        exit(1);
    }
}

//destructor closes files
AbstractTrans::~AbstractTrans() {
    inFile.close();
    outFile.close();
}

//transfer function uses the virtual transform
void AbstractTrans::transfer() {
    char ch;
    char transCh;
    inFile.get(ch);

    while(!inFile.fail()) {

        transCh = transform(ch);
        outFile.put(transCh);
        inFile.get(ch);
    }
}


//Classes with inheritance implementations
class Encryption : public AbstractTrans {

public:
    char transform(char ch) const
    {
        return ch + 1;
    }

    Encryption(char *inFileName, char *outFileName) : AbstractTrans(inFileName, outFileName) {}
};


class UpperCase : public AbstractTrans {

public:
    char transform(char ch) const
    {
        //if the character is a space, period, question mark, or an exclamation mark. leave it be.
        if(ch == SPACE || ch == PERIOD || ch == QUESTION || ch == EXCLAIM) {
            return ch;
        } else {
            return ch - 32;
        }
    }

    UpperCase(char *inFileName, char *outFileName) : AbstractTrans(inFileName, outFileName) {}
};


class NoChange : public AbstractTrans {

public:
    char transform(char ch) const
    {
        return ch;
    }

    NoChange(char *inFileName, char *outFileName) : AbstractTrans(inFileName, outFileName) {}
};



int main()
{
    char *inFileName = "/Users/erichopkins/Projects/Chapter15_5/Chapter15_5/in.txt";
    char *outFileName = "/Users/erichopkins/Projects/Chapter15_5/Chapter15_5/out.txt";
    char *outFileCapitalize = "/Users/erichopkins/Projects/Chapter15_5/Chapter15_5/outCap.txt";
    char *outFileAsIs = "/Users/erichopkins/Projects/Chapter15_5/Chapter15_5/outSame.txt";

    Encryption encryption(inFileName, outFileName);
    encryption.transfer();

    UpperCase upperCase(inFileName, outFileCapitalize);
    upperCase.transfer();

    NoChange noChange(inFileName, outFileAsIs);
    noChange.transfer();

    return 0;
}