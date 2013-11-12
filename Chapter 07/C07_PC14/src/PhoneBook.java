public class PhoneBook {
    private String name;
    private String phoneNumber;


    //==Setters==//
    public void setName(String name) {
        this.name = name;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }
    //==Getters==//
    public String getName() {
        return name;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }
    //==Constructors==//
    //default (ie. fallback)
    public PhoneBook() {
        name = "null";
        phoneNumber = "(000)-000-0000";
    }
    //standard
    public PhoneBook(String name, String phoneNumber) {
        this.name = name;
        this.phoneNumber = phoneNumber;
    }
}
