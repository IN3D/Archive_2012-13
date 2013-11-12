import java.util.ArrayList;

public class PhoneBookProg {

    public static void main(String[] args){

        //create an array list
        ArrayList<PhoneBook> PBookList = new ArrayList<PhoneBook>();

        //add five items to it
        PBookList.add(new PhoneBook("Joe Public","(248)-420-5699"));
        PBookList.add(new PhoneBook("Kemal Erdogan","(734)-595-8765"));
        PBookList.add(new PhoneBook("Jaco Van Zyl","(248)-449-8865"));
        PBookList.add(new PhoneBook("Chris Jackson","(313)-998-7649"));
        PBookList.add(new PhoneBook("Ubbe Ragnarsonn","(248)-695-4423"));

        //print out what is in the list
        for (int i = 0; i < PBookList.size(); i++) {
            PhoneBook item = (PhoneBook)PBookList.get(i);
            System.out.println("Name: "+item.getName()+"\n"+"Number: "+item.getPhoneNumber()+".");
        }


    }

}
