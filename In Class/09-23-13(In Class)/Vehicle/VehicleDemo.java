/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 23/09/13
 * Time: 8:33 PM
 * To change this template use File | Settings | File Templates.
 */
import javax.swing.*;


public class VehicleDemo
{
    public static void main(String[] args)
    {
       Vehicle vOne = new Vehicle();

       vOne.setVehName(JOptionPane.showInputDialog("Enter a vehicle name."));

        JOptionPane.showMessageDialog(null,"The name of the vehicle is "+vOne.getVehName());
    }
}
