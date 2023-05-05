Hotel hotel1 = new Hotel();
hotel1.id = 1;
hotel1.HotelName = "23 Hotel";
hotel1.Address = "Baki şəhəri, Nizami rayonu";
hotel1.RoomPrice = 70;
hotel1.RoomCount = 2;

Console.WriteLine(hotel1.CalcRoomPrice());

public class Hotel
{
    public int id;
    public int RoomCount;
    public string HotelName;
    public string Address;
    public int RoomPrice;

    public int CalcRoomPrice()
    {
        return RoomCount * RoomPrice;
    }



}
