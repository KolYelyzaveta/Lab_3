using Hostels;
using Lab_3;
using System.Collections.Generic;
using System.IO;
using System.Drawing.Text;
using Microsoft.VisualBasic.Devices;

public static class Campus
{

    public static List<Hostel> hostels = new List<Hostel>(0);
    public static List<Student> CampusStudents = new List<Student>(0);
    public static List<int> DeleteHostels = new List<int>(0);
    public static List<int> DeletedID = new List<int>(0);
    public static int LastID = 0;

    public static int GetID()
    {
        if (DeleteHostels.Count != 0)
        {
            int temp = DeleteHostels[0];
            DeleteHostels.RemoveAt(0);
            return temp;
        }
        else if (hostels.Count == 0)
        {
            return 1;
        }
        else
        {
            int max = 0, value = 0;
            for (int i = 0; i < hostels.Count; i++)
            {
                value = hostels[i].ID;
                if (value > max) max = value;
            }
            return max + 1;
        }
    }

    public static bool switchImageString(string str)
    {
        if (str != "")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool switchImageInt(string str, out int num)
    {
        if (str != "" && int.TryParse(str, out num) && num >= 0)
        {
            return true;
        }
        else
        {
            num = -1;
            return false;
        }
    }

    public static bool FindingHostel(int id, out Hostel? hostel)
    {
        hostel = hostels.Find(h => h.ID == id);
        if (hostel == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static void WritingInFiles()
    {
        DirectoryInfo dirInfo = new DirectoryInfo(@"..\..\..\CampusData");
        if (!dirInfo.Exists)
        {
            dirInfo.Create();
        }
        using (StreamWriter writer = new StreamWriter(@"..\..\..\CampusData\Data.txt", false))
        {
            writer.WriteAsync($"{hostels.Count}\n");
            for (int i = 0; i < hostels.Count; i++)
            {
                writer.WriteAsync($"{hostels[i].ID}\n{hostels[i].universityName}\n{hostels[i].hostelAddress}\n");
                writer.WriteAsync($"{hostels[i].Rooms.Count}\n");
                for (int j = 0; j < hostels[i].Rooms.Count; j++)
                {
                    writer.WriteAsync($"{hostels[i].Rooms[j].ID}\n{hostels[i].Rooms[j].roomType}\n");
                    writer.WriteAsync($"{hostels[i].Rooms[j].IDrecordBooks.Count}\n");
                    for (int k = 0; k < hostels[i].Rooms[j].IDrecordBooks.Count; k++)
                    {
                        writer.WriteLineAsync(hostels[i].Rooms[j].IDrecordBooks[k]);
                    }
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(@"..\..\..\CampusData\Students.txt", false))
        {
            writer.WriteAsync($"{hostels.Count}\n");
            for (int i = 0; i < hostels.Count; i++)
            {
                writer.WriteAsync($"{hostels[i].Students.Count}\n");
                for (int j = 0; j < hostels[i].Students.Count; j++)
                {
                    writer.WriteAsync($"{hostels[i].Students[j].FullName[0]}\n{hostels[i].Students[j].FullName[1]}\n" +
                        $"{hostels[i].Students[j].FullName[2]}\n{hostels[i].Students[j].Faculty}\n{hostels[i].Students[j].Group}\n" +
                        $"{hostels[i].Students[j].sex}\n{hostels[i].Students[j].Course}\n{hostels[i].Students[j].IDrecordBook}\n");
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(@"..\..\..\CampusData\Workers.txt", false))
        {
            writer.WriteAsync($"{hostels.Count}\n");
            for (int i = 0; i < hostels.Count; i++)
            {
                writer.WriteAsync($"{hostels[i].Workers.Count}\n");
                for (int j = 0; j < hostels[i].Workers.Count; j++)
                {
                    writer.WriteAsync($"{hostels[i].Workers[j].Name[0]}\n{hostels[i].Workers[j].Name[1]}\n{hostels[i].Workers[j].position}\n" +
                             $"{hostels[i].Workers[j].IndividualTaxNumber}\n");
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(@"..\..\..\CampusData\Campus.txt", false))
        {
            writer.WriteAsync($"{CampusStudents.Count}\n");
            for (int i = 0; i < CampusStudents.Count; i++) writer.WriteAsync($"{CampusStudents[i].FullName[0]}\n{CampusStudents[i].FullName[1]}\n{CampusStudents[i].FullName[2]}\n" +
                        $"{CampusStudents[i].Faculty}\n{CampusStudents[i].Group}\n{CampusStudents[i].sex}\n{CampusStudents[i].Course}\n" +
                        $"{CampusStudents[i].IDrecordBook}\n");

            writer.WriteAsync($"{DeleteHostels.Count}\n");
            for (int i = 0; i < DeleteHostels.Count; i++) writer.WriteAsync($"{DeleteHostels[i]}\n");

            writer.WriteAsync($"{DeletedID.Count}\n");
            for (int i = 0; i < DeletedID.Count; i++) writer.WriteAsync($"{DeletedID[i]}\n");

            writer.WriteLine($"{LastID}");
        }

        MessageBox.Show($"Інформація записана в файл", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


    public static void ReadingFromFiles()
    {
        hostels.Clear();
        CampusStudents.Clear();
        DeleteHostels.Clear();
        DeletedID.Clear();
        LastID = 0;

        using (StreamReader reader = new StreamReader(new FileStream(@"..\..\..\CampusData\Data.txt", FileMode.Open)))
        {
            int hostelsNumber = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < hostelsNumber; i++)
            {
                int ID = Convert.ToInt32(reader.ReadLine());
                string univName = reader.ReadLine().ToString();
                string hostleAddress = reader.ReadLine().ToString();
                List<Worker> workers = new List<Worker>(0);
                List<Room> rooms = new List<Room>(0);
                Campus.hostels.Add(new Hostel(ID, univName, hostleAddress, workers, rooms));

                int roomsNumber = Convert.ToInt32(reader.ReadLine());
                for (int j = 0; j < roomsNumber; j++)
                {
                    int roomID = Convert.ToInt32(reader.ReadLine());                    
                    Enum.TryParse<RoomType>(reader.ReadLine().ToString(), out RoomType rt);
                    hostels[i].Rooms.Add(new Room(roomID, rt, null));

                    int booksNumber = Convert.ToInt32(reader.ReadLine());
                    for (int k = 0; k < booksNumber; k++)
                    {
                        hostels[i].Rooms[j].IDrecordBooks.Add(reader.ReadLine().ToString());
                    }
                }
                hostels[i].CalcProfit();
            }
        }

        using (StreamReader reader = new StreamReader(new FileStream(@"..\..\..\CampusData\Campus.txt", FileMode.Open)))
        {
            int campusStudentNumber = Convert.ToInt32(reader.ReadLine());
            for (int j = 0; j < campusStudentNumber; j++)
            {               
                Campus.CampusStudents.Add(ReadFromFile(reader));
            }
            int deletedHostelsNumber = Convert.ToInt32(reader.ReadLine());
            for (int j = 0; j < deletedHostelsNumber; j++)
            {
                Campus.DeleteHostels.Add(Convert.ToInt32(reader.ReadLine()));
            }
            int deletedIDNumber = Convert.ToInt32(reader.ReadLine());
            for (int j = 0; j < deletedIDNumber; j++)
            {
                Campus.DeletedID.Add(Convert.ToInt32(reader.ReadLine()));
            }
            Campus.LastID = Convert.ToInt32(reader.ReadLine());
        }

        using (StreamReader reader = new StreamReader(new FileStream(@"..\..\..\CampusData\Students.txt", FileMode.Open)))
        {
            int hostelsNumber = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < hostelsNumber; i++)
            {
                int studentsNumber = Convert.ToInt32(reader.ReadLine());
                for (int j = 0; j < studentsNumber; j++)
                {
                    Campus.hostels[j].Students.Add(ReadFromFile(reader));
                    hostels[i].CalcProfit();
                }
            }
        }

        using (StreamReader reader = new StreamReader(new FileStream(@"..\..\..\CampusData\Workers.txt", FileMode.Open)))
        {
            int hostelsNumber = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < hostelsNumber; i++)
            {
                int workersNumber = Convert.ToInt32(reader.ReadLine());
                for (int j = 0; j < workersNumber; j++)
                {
                    string[] Name = new string[2];
                    Name[0] = reader.ReadLine().ToString();
                    Name[1] = reader.ReadLine().ToString();
                    Enum.TryParse<Position>(reader.ReadLine().ToString(), out Position position);
                    string IndividualTaxNumber = reader.ReadLine().ToString();
                    Campus.hostels[i].Workers.Add(new Worker(Name, position, IndividualTaxNumber));
                    hostels[i].CalcProfit();
                }
            }
        }

        MessageBox.Show($"Інформація завантажена", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private static Student ReadFromFile(StreamReader reader)
    {
        string[] FullName = new string[3];
        FullName[0] = reader.ReadLine().ToString();
        FullName[1] = reader.ReadLine().ToString();
        FullName[2] = reader.ReadLine().ToString();
        string Faculty = reader.ReadLine().ToString();
        string Group = reader.ReadLine().ToString();
        //(Sex)Convert.ToInt32(reader.ReadLine());
        Enum.TryParse<Sex>(reader.ReadLine().ToString(), out Sex sex);
        Enum.TryParse<CourseNumber>(reader.ReadLine().ToString(), out CourseNumber Course);
        string IDRecBooks = reader.ReadLine().ToString();
        return new Student(FullName, Faculty, sex, Group, IDRecBooks, Course);
    }

    public static long LongRandom(long min, long max, Random rand)
    {
        long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
        result = (result << 32);
        result = result | (long)rand.Next((Int32)min, (Int32)max);
        return result;
    }

}

