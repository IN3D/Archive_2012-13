public class Month {

    private int monthNumber;

    public Month() {
        monthNumber = 1;
    }

    public Month(int m) {
        monthNumber = m;

        if (monthNumber < 1 || monthNumber > 12) {
        monthNumber = 1;
        }
    }

    public Month(String name) {
        if (name == "January")
            monthNumber = 1;
        else if (name == "February")
            monthNumber = 2;
        else if (name == "March")
            monthNumber = 3;
        else if (name == "April")
            monthNumber = 4;
        else if (name == "May")
            monthNumber = 5;
        else if (name == "June")
            monthNumber = 6;
        else if (name == "July")
            monthNumber = 7;
        else if (name == "August")
            monthNumber = 8;
        else if (name == "September")
            monthNumber = 9;
        else if (name == "October")
            monthNumber = 10;
        else if (name == "November")
            monthNumber = 11;
        else if (name == "December")
            monthNumber = 12;
        else
            monthNumber = 1;
    }

    public void setMonthNumber(int n) {
        monthNumber = n;
        if (monthNumber < 1 || monthNumber > 12)
            monthNumber = 1;
    }

    public int getMonthNumber() {
        return monthNumber;
    }

    public String getMonthName() {
        String name;

        if (monthNumber == 1)
            name = "January";
        else if (monthNumber == 2)
            name = "Febuary";
        else if (monthNumber == 3)
            name = "March";
        else if (monthNumber == 4)
            name = "April";
        else if (monthNumber == 5)
            name = "May";
        else if (monthNumber == 6)
            name = "June";
        else if (monthNumber == 7)
            name = "July";
        else if (monthNumber == 8)
            name = "August";
        else if (monthNumber == 9)
            name = "September";
        else if (monthNumber == 10)
            name = "October";
        else if (monthNumber == 11)
            name = "November";
        else
            name = "December";

        return name;
    }
    //this book isn't clear on what this is supposed to do
    //waiting on the professor to confirm
    public String toString(int i) {
        String name;

        if (i == 1)
            name = "January";
        else if (i == 2)
            name = "Febuary";
        else if (i == 3)
            name = "March";
        else if (i == 4)
            name = "April";
        else if (i == 5)
            name = "May";
        else if (i == 6)
            name = "June";
        else if (i == 7)
            name = "July";
        else if (i == 8)
            name = "August";
        else if (i == 9)
            name = "September";
        else if (i == 10)
            name = "October";
        else if (i == 11)
            name = "November";
        else if (i == 12)
            name = "December";
        else
            name = "Invalid month number.";

        return name;
    }

    public boolean equals(Month eo) {

        if (this.monthNumber == eo.getMonthNumber()) {
            return true;
        } else {
            return false;
        }
    }

    public boolean greaterThan(Month eo) {

        if (this.monthNumber > eo.getMonthNumber()) {
            return true;
        } else {
            return false;
        }
    }

    public boolean lessThan(Month eo) {

        if (this.monthNumber < eo.getMonthNumber()) {
            return true;
        } else {
            return false;
        }
    }

}
