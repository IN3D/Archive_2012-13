/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 07/10/13
 * Time: 6:57 PM
 * To change this template use File | Settings | File Templates.
 */
public class Hotel
{
    //inputs
    private double floors;
    private double rooms;
    private double roomsOccupied;
    private double roomsVacant;
    //totals
    private double totalRooms;
    private double totalOccupied;
    private double totalVacant;
    private double occupancyRate;

    /**Accessors**/
    public double getFloors()
    {
        return floors;
    }
    public double getRooms()
    {
        return rooms;
    }
    public double getRoomsOccupied()
    {
        return roomsOccupied;
    }
    public double getTotalRooms()
    {
        return totalRooms;
    }
    public double getTotalOccupied()
    {
        return totalOccupied;
    }
    public double getTotalVacant()
    {
        return totalVacant;
    }
    public double getOccupancyRate()
    {
        return occupancyRate;
    }

    /**Modifiers**/
    public void setFloors(double pFloors)
    {
        floors = pFloors;
    }
    public void setRooms(double pRooms)
    {
        rooms = pRooms;
        AllRooms(); //ensures the calculations gets run (with less calls)
    }
    public void setRoomsOccupied(double pRoomsOccupied)
    {
        roomsOccupied = pRoomsOccupied;
        AllOccupied(); //ensures the calculations stays up to date.
        RoomsVacant();
    }

    /**Calculations**/
    public void OccupantRate()
    {
        occupancyRate = (totalOccupied / totalRooms);
    }


    /**Internal Calculations**/
    /*These exist internally and shouldn't be called outside of this class*/
    private void AllRooms()
    {
        totalRooms += rooms;
    }
    private void AllOccupied()
    {
        totalOccupied += roomsOccupied;
    }
    private void RoomsVacant()
    {
        roomsVacant = (rooms - roomsOccupied);
        //ensures this calculation is always preformed
        AllVacancies();
    }
    private void AllVacancies()
    {
        totalVacant += roomsVacant;
    }
}
