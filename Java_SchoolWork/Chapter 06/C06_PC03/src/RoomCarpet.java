public class RoomCarpet {

    private double priceSqFoot;
    private double area;

    public void RoomDimension(RoomDimension eo) {


        area = eo.roomArea();
    }

    public double priceCalc() {
        //double priceSqFoot = p;

        double finalPrice = priceSqFoot * area;

        return finalPrice;
    }

    public double getPriceSqFoot(double p) {
        priceSqFoot = p;
        return priceSqFoot;
    }
}
