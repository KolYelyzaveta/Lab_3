public class Student
{
    private string iDrecordBook;

    public string[] FullName { get; set; } = new string[3]; //Name Surname Patronymic
    public string Faculty { get; set; }
    public Sex sex { get; set; }
    public string Group { get; set; }
    public string IDrecordBook
    {
        get => iDrecordBook;
        set
        {
            if (value.Length == 8) iDrecordBook = value;
            else throw new Exception("IDrecordBook error");
        }
    }
    public CourseNumber Course { get; set; }

    public Student(string[] fullName, string Faculty, Sex sex, string Group, string? iDrecordBook, CourseNumber Course)
    {
        FullName = fullName;
        this.Faculty = Faculty;
        this.sex = sex;
        this.Group = Group;
        if (iDrecordBook == null || iDrecordBook == "") IDrecordBook = GeneratingIDrecordBook();
        else IDrecordBook = iDrecordBook;
        this.Course = Course;
    }

    private string GeneratingIDrecordBook() => Campus.LongRandom(10000000L, 99999999L, new Random()).ToString();
}

public enum Sex
{
    Male = 'Ч',
    Female = 'Ж'
}

public enum CourseNumber
{
    I = 1,
    II = 2,
    III = 3,
    IV = 4,
    V = 5
}
