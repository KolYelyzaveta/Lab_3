using System.Text;

namespace Lab_3;
public class Worker
{
    private int salary;
    private string individualTaxNumber;

    public string[] Name { get; set; } = new string[2]; //Name Surname
    public Position position { get; set; }
    public int Salary
    {
        get => salary;
        set
        {
            if (value >= 8000 && value <= 40000) salary = value;
            else throw new Exception("Salary error");
        }
    }
    public string IndividualTaxNumber
    {
        get => individualTaxNumber;
        set
        {
            long temp;
            if (value.Length == 10 && long.TryParse(value, out temp)) individualTaxNumber = value;
            else throw new Exception("IndividualTaxNumber error");
        }
    }

    public Worker(string[] name, Position position, string? individualTaxNumber)
    {
        Name = name;
        this.position = position;
        Salary = (int)position;
        if (individualTaxNumber is null || individualTaxNumber == "") IndividualTaxNumber = GenerationTaxNumber();
        else IndividualTaxNumber = individualTaxNumber.ToString();
    }

    private string GenerationTaxNumber() => Campus.LongRandom(1000000000L, 9999999999L, new Random()).ToString();
}


public enum Position
{
    Commandant = 30000,
    Head_of_economic_part = 25000,
    Guard = 10000,
    Cleaner = 8000
}