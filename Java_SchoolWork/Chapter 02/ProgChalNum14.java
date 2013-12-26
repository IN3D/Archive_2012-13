/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 17/09/13
 * Time: 1:12 AM
 * To change this template use File | Settings | File Templates.
 */
public class ProgChalNum14
{
    public static void main(String[] args)
    {
        //declare needed variables
        int int_sharesBought = 600;
        double dbl_sharePrice = 21.77;
        double dbl_stockCost = 0.0; //initialized before use
        double dbl_commissionCost = 0.0; //initialized before use
        double dbl_finalCost = 0.0; //initialized before use
        final double COMMISSION = 0.02;

        System.out.println("Kathryn has bought "+int_sharesBought+" stocks at $"+dbl_sharePrice+" each.");

        //calculate the price of just the stock purchase
        dbl_stockCost = int_sharesBought * dbl_sharePrice;

        System.out.println("The cost of just the shares bought will be $"+dbl_stockCost+".\n");

        System.out.println("However, she owes her stock broker a commission of 2%.");

        //calculate the amount owed to the stock broker
        dbl_commissionCost = dbl_stockCost * COMMISSION;

        System.out.println("So she owes the broker $"+dbl_commissionCost+".\n");

        //calculate the final price
        dbl_finalCost = dbl_stockCost + dbl_commissionCost;

        System.out.println("The final cost, the cost of the stocks and commission is $"+dbl_finalCost+".");
    }
}
