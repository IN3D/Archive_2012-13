/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 04/10/13
 * Time: 5:16 PM
 * To change this template use File | Settings | File Templates.
 */
public class WidgetFactory
{
    int numOrdered;
    int daysToMake;
    //10 widgets an hour, in 2 8-hour shifts.
    //these number could be changed as needed.
    final int WidgetsPerDay = (10 * (8 * 2)); /**160**/

    /**Accessors**/
    public int getNumOrdered()
    {
        return numOrdered;
    }
    public int getDaysToMake()
    {
        return daysToMake;
    }
    public int getWidgetsPerDay()
    {
        return WidgetsPerDay;
    }

    /**Modifiers**/
    public void NumberRequested(int pRequested)
    {
        numOrdered = pRequested;
    }

    /**!!--Methods for Production Calculation--!!**/

    /**Rounding Method**/
    /*This method takes a number and it's divisor and rounds it
    * if there is any remainder on the division.*/
    public static int roundUp(int num, int divisor)
    {
        return (num + divisor -1)/divisor;
    }
    /**Request Method**/
    public int FactoryCalculation()
    {
        /*Calculate how many days it will take to make
        the requested amount widgets.Rounded for any remainder.
        I.E. 6.025 days will be completed in 7 days as the production
        just spills over into the next day.*/
        daysToMake = roundUp(numOrdered,WidgetsPerDay);


        return daysToMake;
    }
}
