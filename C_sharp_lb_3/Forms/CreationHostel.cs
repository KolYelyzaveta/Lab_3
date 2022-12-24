using Hostels;
using Lab_3;
using System.Security.Policy;

namespace Lab_2
{
    public partial class CreationHostel : Form
    {
        bool trigger1 = false, trigger2 = false, trigger3 = false;

        bool tr1_1 = false, tr1_2 = false, tr2_1 = false, tr2_2 = false, tr3_1 = false, tr3_2 = false,
            tr4_1 = false, tr4_2 = false, tr5_1 = false, tr5_2 = false, tr6_1 = false, tr6_2 = false, tr7_1 = false, tr7_2 = false,
            tr8_1 = false, tr8_2 = false, tr9_1 = false, tr9_2 = false, tr10_1 = false, tr10_2 = false;

        public CreationHostel()
        {
            InitializeComponent();
        }

        private void ChangingPhotoTriggers(ref object sender, ref bool trigger, ref bool toCompare)
        {
            if (Campus.switchImageString(((TextBox)sender).Text))
            {
                trigger = true;
            }
            else
            {
                trigger = false;
            }
        }

        private void tb_name10_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr10_2, ref tr10_1);
        private void tb_surname10_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr10_1, ref tr10_2);

        private void tb_name9_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr9_2, ref tr9_1);

        private void CreationHostel_Load(object sender, EventArgs e)
        {

        }

        private void lb_hostelAddress_Click(object sender, EventArgs e)
        {

        }

        private void tb_surname9_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr9_1, ref tr9_2);

        private void tb_name8_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr8_2, ref tr8_1);
        private void tb_surname8_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr8_1, ref tr8_2);

        private void tb_name7_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr7_2, ref tr7_1);
        private void tb_surname7_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr7_1, ref tr7_2);

        private void tb_name6_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr6_2, ref tr6_1);
        private void tb_surname6_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr6_1, ref tr6_2);

        private void tb_name5_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr5_2, ref tr5_1);
        private void tb_surname5_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr5_1, ref tr5_2);

        private void tb_name4_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr4_2, ref tr4_1);
        private void tb_surname4_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr4_1, ref tr4_2);

        private void tb_name3_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr3_2, ref tr3_1);
        private void tb_surname3_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr3_1, ref tr3_2);

        private void tb_name2_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr2_2, ref tr2_1);
        private void tb_surname2_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr2_1, ref tr2_2);

        private void tb_name1_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr1_2, ref tr1_1);
        private void tb_surname1_TextChanged(object sender, EventArgs e) => ChangingPhotoTriggers(ref sender, ref tr1_1, ref tr1_2);

        private void tb_1_TextChanged(object sender, EventArgs e)
        {
            string? text = ((TextBox)sender).Text;
            if (Campus.switchImageString(text) && text != "Hotels" && text != "Rooms") //Останні дві перевірки виключають ключові слова при запису в файли
            {
                trigger1 = true;
            }
            else
            {
                trigger1 = false;
            }
        }

        private void tb_hostelAddress_TextChanged(object sender, EventArgs e)
        {
            string? text = ((TextBox)sender).Text;
            if (Campus.switchImageString(text) && text != "Hotels" && text != "Rooms")
            {
                trigger2 = true;
            }
            else
            {
                trigger2 = false;
            }
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (tr1_1 && tr1_2 && tr2_1 && tr2_2 && tr3_1 && tr3_2 && tr4_1 && tr4_2 && tr5_1
                && tr5_2 && tr6_1 && tr6_2 && tr7_1 && tr7_2 && tr8_1 && tr8_2 && tr9_1 && tr9_2) trigger3 = true;
            else trigger3 = false;
            if (trigger1 && trigger2 && trigger3)
            {
                int controlAmountValues = Campus.hostels.Count;
                List<Worker> workers = new List<Worker>();
                List<Room> rooms = new List<Room>();
                for (int i = 0; i < 50; i++)
                {
                    if (i < 10) rooms.Add(new Room(null, RoomType.Comfort, null));
                    else if (i >= 10 && i < 40) rooms.Add(new Room(null, RoomType.Standart, null));
                    else if (i >= 40) rooms.Add(new Room(null, RoomType.Single, null));
                }
                workers.Add(new Worker(new string[] { tb_name1.Text, tb_surname1.Text }, Position.Commandant, null));
                workers.Add(new Worker(new string[] { tb_name2.Text, tb_surname2.Text }, Position.Head_of_economic_part, null));
                workers.Add(new Worker(new string[] { tb_name3.Text, tb_surname3.Text }, Position.Guard, null));
                workers.Add(new Worker(new string[] { tb_name4.Text, tb_surname4.Text }, Position.Guard, null));
                workers.Add(new Worker(new string[] { tb_name5.Text, tb_surname5.Text }, Position.Cleaner, null));
                workers.Add(new Worker(new string[] { tb_name6.Text, tb_surname6.Text }, Position.Cleaner, null));
                workers.Add(new Worker(new string[] { tb_name7.Text, tb_surname7.Text }, Position.Cleaner, null));
                workers.Add(new Worker(new string[] { tb_name8.Text, tb_surname8.Text }, Position.Cleaner, null));
                workers.Add(new Worker(new string[] { tb_name9.Text, tb_surname9.Text }, Position.Cleaner, null));
                workers.Add(new Worker(new string[] { tb_name10.Text, tb_surname10.Text }, Position.Cleaner, null));
                Campus.hostels.Add(new Hostel(null, tb_univName.Text, tb_hostelAddress.Text, workers, rooms));
                if (Campus.hostels.Count == controlAmountValues) MessageBox.Show("New hostel hasn`t been created!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show($"Новий гуртожиток номер {Campus.hostels[controlAmountValues].ID}, \nщо відноситься до університету: {Campus.hostels[controlAmountValues].universityName}, \nрозташований за адресою: " +
                            $"{Campus.hostels[controlAmountValues].hostelAddress}, \nз {Campus.hostels[controlAmountValues].StuffNumber} працівниками та {Campus.hostels[controlAmountValues].RoomsNumber} " +
                            $"кімнатами був успішно створений. \nЙого поточний прибуток становить: {Campus.hostels[controlAmountValues].hostelProfit} грн.",
                            "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                }
            }
            else
            {
                MessageBox.Show("Перевірте правильність введення даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
