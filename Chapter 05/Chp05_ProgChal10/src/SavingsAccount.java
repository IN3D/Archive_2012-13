/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 08/10/13
 * Time: 6:43 PM
 * To change this template use File | Settings | File Templates.
 */
public class SavingsAccount
{
    private double accountBalance;
    private double annualInterest;
    private double monthlyInterest;
    private double interestAmount;
    private double withdrawal;
    private double deposit;
    //counters
    private int totalDeposits;
    private int totalWithdrawls;
    private double totalInterest;

    /**Constructor**/
    SavingsAccount(double pAccountBalance)
    {
        accountBalance = pAccountBalance;
    }

    /**getters**/
    public double getAccountBalance()
    {
        return accountBalance;
    }
    public double getMonthlyInterest()
    {
        return monthlyInterest;
    }
    public double getWithdrawal()
    {
        return withdrawal;
    }
    public double getDeposit()
    {
        return deposit;
    }
    public int getTotalDeposits()
    {
        return totalDeposits;
    }
    public int getTotalWithdrawls()
    {
        return totalWithdrawls;
    }
    public double getTotalInterest()
    {
        return totalInterest;
    }

    /**setters**/
    public void setAnnualInterest(double pAnnualInterest)
    {
        pAnnualInterest = pAnnualInterest / 100; //allow the user to input the value whole (ie 5% interest as just 5, rather than having the user put in 0.05
        annualInterest = pAnnualInterest;

        monthlyInterest = annualInterest /= 12;

    }
    public void setWithdrawal(double pWithdrawal)
    {
        withdrawal = pWithdrawal;

        accountBalance -= withdrawal;
        totalWithdrawls++;
    }
    public void setDeposit(double pDeposit)
    {
        deposit = pDeposit;

        accountBalance += deposit;
        totalDeposits++;
    }
    public void Overdraft()
    {
        final double OVERDRAFT = 35.00;
        accountBalance -= OVERDRAFT;
    }

    /**methods**/
    public void InterestForMonth()
    {
        interestAmount = (accountBalance * monthlyInterest);
        accountBalance += interestAmount;
        totalInterest += interestAmount;
    }
}
