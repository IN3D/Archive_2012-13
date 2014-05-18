/**
 * Created with IntelliJ IDEA.
 * User: erich_000
 * Date: 10/4/13
 * Time: 4:28 PM
 * To change this template use File | Settings | File Templates.
 */
public class Pet
{
    String name;
    String type;
    int age;


    /**Accessors**/
    public String getName()
    {
        return name;
    }
    public String getType()
    {
        return type;
    }
    public int getAge()
    {
        return age;
    }

    /**Modifiers**/
    public void setName(String pName)
    {
        name = pName;
    }
    public void setType(String pType)
    {
        type = pType;
    }
    public void setAge(int pAge)
    {
        age = pAge;
    }


}
