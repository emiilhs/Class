Hotel hotel1 = new Hotel();
hotel1.HotelName = "23 Hotel";
hotel1.Address = "Nizami rayonu";
hotel1.RoomPrice = 100;
Console.WriteLine(hotel1.GetPriceRoom(10));



public class Hotel
{
    public int id { get; set; } = 0;
    public int roomCount;
    public string HotelName;
    public string Address;
    public int roomPrice;

    public int RoomPrice
    {
        get { return roomPrice; }
        set
        {
            if (value < 60)
            {
                roomPrice = 0;
            }
            else if (value > 150)
            {
                roomPrice = 0;
            }
            else
            {
                roomPrice = value;
            }
        }
    }

    public int GetPriceRoom(int CountOfRoom)
    {
        if (CountOfRoom < 0)
        {
            CountOfRoom = 0;
        }
        else if(CountOfRoom > 200) 
        {
            CountOfRoom = 0;
        }
        roomCount = CountOfRoom;
        return roomCount * roomPrice;
    }
}
