import java.util.Scanner;

public class RoomDimensionProg {
    public static Scanner keyboard = new Scanner(System.in);

    public static void main(String[] args) {
        double tempL;
        double tempW;

        System.out.println("What is the length of the room? ");
        tempL = keyboard.nextDouble();
        keyboard.nextLine();//probably need
        System.out.println("What is the width of the room? ");
        tempW = keyboard.nextDouble();
        keyboard.nextLine();//probably need

        RoomDimension room1 = new RoomDimension(tempL, tempW);

        RoomCarpet carpet1 = new RoomCarpet();
        carpet1.RoomDimension(room1);

        System.out.println("What is the price of the carpet you're using? ");
        carpet1.getPriceSqFoot(keyboard.nextDouble());

        System.out.println("The price of carpeting your room will be "+carpet1.priceCalc());
    }
}
