import java.util.Scanner;

public class QuarterlySalesProg {
    public static Scanner keyboard = new Scanner(System.in);

    public static void main(String[] args) {

        double totalSales = 0.0;
        double newTotal = 0.0;
        double difference = 0.0;
        int divNum = 0;
        final int DIVS = 6;
        final int QUARTERS = 4;


        double [][] sales = new double[QUARTERS][DIVS];

        for (int i = 0; i < QUARTERS; i++) {
            for(int j = 0; j < DIVS; j++) {
                System.out.println("Quarter "+(i + 1)+", Division "+(j + 1)+": $");
                sales[i][j] = keyboard.nextDouble();
                keyboard.nextLine();
            }
            //total the sales for the quarter
            if (i >= 1) {
                    for (int r = 0; r < sales[i].length; r++) {
                        newTotal += sales[i][r];
                    }
                difference = newTotal - totalSales;
                System.out.println("This Quarter's total was "+newTotal);
                System.out.println("the difference between this Quarter and last Quarter is $"+difference);
                totalSales = newTotal;

            }
              else {
                for (int c = 0; c < sales[i].length; c++) {
                    for (int r = 0; r < sales.length; r++) {
                        totalSales += sales[r][c];
                    }
                }
                System.out.println("The total sales for this Quarter are :$"+totalSales);
            }

            double largest = sales[i][0];
            for(int x=0; x < sales[i].length; x++){
                if(sales[i][x] > largest){
                    largest = sales[i][x];
                    divNum = x;
                }
            }
            System.out.println("Division "+(divNum + 1)+" had the highest sales with $"+largest);
        }

    }
}
