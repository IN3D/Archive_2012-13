/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 23/09/13
 * Time: 8:26 PM
 * To change this template use File | Settings | File Templates.
 */
public class Vehicle
{
    private String mfg;
    private String vehName;
    private int numWheels;
    private double weight;

    /**Accessors**/
    public String getVehName()
    {
        return vehName;
    }
    /**Modifiers**/
    public void setVehName(String pVehName)
    {
        vehName = pVehName;
    }
}
