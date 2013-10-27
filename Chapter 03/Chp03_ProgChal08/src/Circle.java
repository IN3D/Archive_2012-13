/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 04/10/13
 * Time: 6:35 PM
 * To change this template use File | Settings | File Templates.
 */
public class Circle
{
    double radius;
    double area;
    double diameter;
    double circumference;
    final double PI = 3.14159;

    /**Constructor**/
    Circle(double r)
    {
        radius = r;
    }

    /**Accessors**/
    public double getRadius()
    {
        return radius;
    }
    public double getArea()
    {
        return area;
    }
    public double getDiameter()
    {
        return diameter;
    }
    public double getCircumference()
    {
        return circumference;
    }

    /**Modifiers**/
    public void setRadius(double r)
    {
        radius = r;
    }


    /**---Area, Diameter, and Circumference---**/
    public double setArea()
    {
        area = PI * (radius * radius);

        return area;
    }
    public double setDiameter()
    {
        diameter = radius * 2;

        return diameter;
    }
    public double setCircumference()
    {
        circumference = 2 * PI * radius;

        return circumference;
    }
}
