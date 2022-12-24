using Hostels;

public static class Extensions
{
    public static bool find<T>(this List<T> list, T target)
    {
        return list.Contains(target);
    }
}

namespace Lab_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
