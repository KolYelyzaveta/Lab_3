using Hostels;

public class Room
{
    private int id;

    public int ID
    {
        get => id;
        set
        {
            bool finded = false;
            foreach (Hostel hostel in Campus.hostels)
                foreach (Room room in hostel.Rooms)
                    if (room.ID == value) finded = true;
            if (!finded) id = value;
            else throw new Exception("Room ID error. Finded matching!");
        }
    } //Must be unique
    public RoomType roomType { get; set; }
    public int Rent { get; set; }
    public int ResidentsNumber { get => IDrecordBooks.Count; }
    public List<string> IDrecordBooks { get; set; } = new List<string>(0);

    public Room(int? ID, RoomType rt, List<string>? iDrecordBooks)
    {
        if (ID != null) this.ID = (int)ID;
        else this.ID = CreateRoomID();
        roomType = rt;
        Rent = 2400 / (int)rt;
        if (iDrecordBooks is not null) IDrecordBooks = iDrecordBooks;
    }

    private int CreateRoomID()
    {
        if (Campus.DeletedID.Count != 0)
        {
            int temp = Campus.DeletedID[0];
            Campus.DeletedID.RemoveAt(0);
            if (temp > Campus.LastID) Campus.LastID = temp;
            return temp;
        }
        else
        {
            return 1 + Campus.LastID++;
        }
    }
}

public enum RoomType 
{
    Standart = 4,
    Comfort = 2,
    Single = 1
}
