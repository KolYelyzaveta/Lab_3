
using Lab_3;
using Hostels;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab_2.Forms
{

    public partial class CampusManagement : Form
    {
        Hostel? hostel = null;
        public CampusManagement()
        {
            InitializeComponent();
        }

        private void tb_hostelID_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageInt(((TextBox)sender).Text, out int num) && Campus.FindingHostel(num, out hostel))
            {
            }
            else
            {
                hostel = null;
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        private void bt_showInfo_Click(object sender, EventArgs e)
        {
            if(hostel == null)
            {
                MessageBox.Show($"Введіть номер гуртожитку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show(hostel.ToString() + "Чи хочете ви переглянути список студентів гуртожитку?", $"Інформація про гуртожиток № {hostel.ID}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (hostel.Students.Count == 0) MessageBox.Show($"В гуртожитку не проживає ні одного студента!", "Упс", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (Student student in hostel.Students)
                    {
                        sb.Append(student.FullName[1] + " " + student.FullName[0] + " " + student.FullName[2] + " з ІЗК: " + student.IDrecordBook + "\n");
                    }
                    MessageBox.Show(sb.ToString(), "Список студентів", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void bt_calcProfit_Click(object sender, EventArgs e)
        {
            if (hostel is null) MessageBox.Show($"Введіть номер гуртожитку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (rb_month.Checked) MessageBox.Show($"Місячний прибуток гуртожитку № {hostel.ID} становить: {hostel.hostelProfit} грн.", "Місячний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rb_6month.Checked) MessageBox.Show($"Піврічний прибуток гуртожитку № {hostel.ID} становить: {hostel.hostelProfit * 6} грн.", "Піврічний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rb_year.Checked) MessageBox.Show($"Річний прибуток гуртожитку № {hostel.ID} становить: {hostel.hostelProfit * 12} грн.", "Річний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show($"Оберіть період для розрахунку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckingStringInputValuesOnNull(string[] arr)
        {
            foreach (string str in arr)
            {
                if (str == "" || str is null)
                {
                    MessageBox.Show($"Введіть обов'язкові значення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool CheckArrayIDMatchingValues(string ID)
        {
            if (Campus.CampusStudents.Count > 0)
            {
                foreach (Student student in Campus.CampusStudents)
                {
                    if (student.IDrecordBook == ID) return true;
                }
            }
            return false;
        }

        private void bt_addStudents_Click(object sender, EventArgs e)
        {
            string[] arrString = new string[7] // Заносимо значення з полів вводу в масив
            {
                tb_st_name.Text,
                tb_st_surname.Text,
                tb_st_patronymic.Text,
                tb_st_faculty.Text,
                tb_st_group.Text,
                tb_st_course.Text,
                tb_st_sex.Text
            };
            bool ch_ok = true;
            bool id_ok = false;
            char ch = ' ';

            if (tb_st_ID.Text.Length != 0)
                if (tb_st_ID.Text.Length != 8 || !int.TryParse(tb_st_ID.Text, out int num)) MessageBox.Show($"Перевірте правильність вводу ідентифікатора!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (CheckArrayIDMatchingValues(tb_st_ID.Text)) MessageBox.Show($"Такий ідентифікатор вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else id_ok = true;
            else id_ok = true;

            if (tb_st_sex.Text.Length == 1) ch = tb_st_sex.Text[0];
            else ch_ok = false;

            if (CheckingStringInputValuesOnNull(arrString) && id_ok && ch_ok && Enum.IsDefined(typeof(Sex), (Sex)ch) &&
                Enum.IsDefined(typeof(CourseNumber), Convert.ToInt32(tb_st_course.Text))) // Перевіряємо масив на пусті значення та звіряємо значення 
            {

                Enum.TryParse(tb_st_sex.Text, out Sex s);
                Enum.TryParse(tb_st_course.Text, out CourseNumber c);
                Campus.CampusStudents.Add(new Student(new string[] { tb_st_name.Text, tb_st_surname.Text, tb_st_patronymic.Text }, tb_st_faculty.Text, s, tb_st_group.Text, tb_st_ID.Text, c));

                StringBuilder sb = new StringBuilder();
                sb.Append(Campus.CampusStudents[^1].FullName[1] + " ");
                sb.Append(Campus.CampusStudents[^1].FullName[0] + " ");
                sb.Append(Campus.CampusStudents[^1].FullName[2]);
                MessageBox.Show($"Студент з ім'ям {sb.ToString()}, \nщо вчиться на факультеті {Campus.CampusStudents[^1].Faculty} в групі {Campus.CampusStudents[^1].Group} на {Campus.CampusStudents[^1].Course} курсі був успішно створений. " +
                    $"\nНомер залікової книжки: {Campus.CampusStudents[^1].IDrecordBook}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show($"Перевірте правильність вводу даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckingRoomExistence(int room_ID, out Room? resRoom)
        {
            foreach (Room room in hostel.Rooms)
            {
                if (room.ID == room_ID)
                {
                    resRoom = room;
                    return true;
                }
            }
            MessageBox.Show($"Кімнати з таким номером не існує в цьому гутожитку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            resRoom = null;
            return false;
        }

        private bool CheckingOnNumberValues(string[] arr, ref List<int>? intNumbers)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (!int.TryParse(arr[i], out int num) || i == 0 && arr[i].Length != 8)
                {
                    MessageBox.Show($"Введіть в поля числа!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intNumbers = null;
                    return false;
                }

                intNumbers.Add(num);
            }
            return true;
        }

        private bool VerificationStudentDontLiveInHostel(string numIdBook)
        {
            foreach (Student stud in hostel.Students) // Перевіряємо, що студент відсутній в списках гуртожитку
            {
                if (stud.IDrecordBook == numIdBook)
                {
                    MessageBox.Show($"Студент вже проживає в гуртожитку, його необхідно перепоселити!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool VerificationStudentExistence(string numIdBook, out Student? resStudent)
        {
            foreach (Student student in Campus.CampusStudents) // Перевіряємо, що студент існує в списках кампуса
            {
                if (student.IDrecordBook == numIdBook)
                {
                    resStudent = student; // Якщо так, то заносимо посилання на об'єкт в змінну                    
                    return true;
                }
            }
            MessageBox.Show($"Студента з таким номером залікової книжки неіснує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            resStudent = null;
            return false;
        }

        private bool CheckingFreePlaceSexualCompatibility(Room room, Student student)
        {
            if (room.ResidentsNumber == (int)room.roomType) // Порівнюємо кількість проживаючих студентів з максимальною вмістимістю кімнати
            {
                MessageBox.Show($"В обраній кімнаті недостатньо вільних місць!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (room.IDrecordBooks.Count > 0) // Якщо кімната не пустує
            {
                foreach (Student st in hostel.Students) // Шукаэмо першого студента, що проживає в кімнаті в списку студентів гуртожитку
                {
                    if (st.IDrecordBook == room.IDrecordBooks[0])
                    {
                        if (st.sex != student.sex) // Якщо стать цього студента не збігається зі статтю додаваємого, то виводимо помилку
                        {
                            MessageBox.Show($"Статі проживаючих студентів в кімнаті не збігаються зі статтю студента, що додається!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else break;
                    }
                }
            }
            return true;
        }

        private bool CheckStudentLiveInRoom(Room room, Student student)
        {
            if (room.IDrecordBooks.find(student.IDrecordBook)) return true;
            else
            {
                MessageBox.Show($"Даний студент не проживає в даній кімнаті!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool StudentCheckingManager(int switching, out Student? st, out Room? rm, out Room? rm2, ref string[] arrString)
        {
            st = null;
            rm = null;
            rm2 = null;
            if (hostel is null) // Перевірка на 
            {
                MessageBox.Show($"Введіть номер гуртожитку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            List<int>? intNumbers = new List<int>(0);
            Room? room2 = null;

            if (CheckingStringInputValuesOnNull(arrString)  // Перевірка на те, що всі дані були введені
                && CheckingOnNumberValues(arrString, ref intNumbers) // Перевірка на те, що введені дані є числами 
                && CheckingRoomExistence(intNumbers[1], out Room? room) // Перевірка на те, що вказана кімната існує
                && (switching != 3 || CheckingRoomExistence(intNumbers[2], out room2)) // Перевірка на те, що друга вказана кімната існує 
                && VerificationStudentExistence(tb_Record_ID.Text, out Student? student) // Перевірка на те, що вказаний студент існує
                && (switching != 1 || (VerificationStudentDontLiveInHostel(tb_Record_ID.Text) && CheckingFreePlaceSexualCompatibility(room, student))) // Перевірка на відповідність статі та наявності вільного місця в кімнаті  
                && (switching == 1 || CheckStudentLiveInRoom(room, student)) // Перевірка на відповідність статі та наявності вільного місця в кімнаті  
                && (switching != 3 || CheckingFreePlaceSexualCompatibility(room2, student)) // Перевірка на відповідність статі та наявності вільного місця в кімнаті  
                )
            {
                st = student;
                rm = room;
                if (room2 is not null) rm2 = room2;
                return true;
            }
            else return false;
        }

        private void bt_st_add_Click(object sender, EventArgs e)
        {
            string[] arrString = new string[2] // Заносимо значення з полів вводу в масив
            {
                tb_Record_ID.Text,
                tb_Room_num_1.Text
            };

            if (StudentCheckingManager(1, out Student? student, out Room? room, out Room? room2, ref arrString)) // Перевірка на відповідність статі та наявності вільного місця в кімнаті
            {
                hostel.Students.Add(student);
                room.IDrecordBooks.Add(tb_Record_ID.Text);
                MessageBox.Show($"Студент з ідентифікатором залікової книжки: {student.IDrecordBook}, \nбув доданий до гуртожитку номер {hostel.ID} до кімнати номер {room.ID}.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hostel.CalcProfit();
            }
        }

        private void bt_st_del_Click(object sender, EventArgs e)
        {
            string[] arrString = new string[2] // Заносимо значення з полів вводу в масив
            {
                tb_Record_ID.Text,
                tb_Room_num_1.Text
            };
            if (StudentCheckingManager(2, out Student? student, out Room? room, out Room? room2, ref arrString)) // Перевірка на відповідність статі та наявності вільного місця в кімнаті
            {
                hostel.Students.Remove(student);
                room.IDrecordBooks.Remove(tb_Record_ID.Text);
                MessageBox.Show($"Студент з ідентифікатором залікової книжки: {student.IDrecordBook}, \nбув видалений з гуртожитку номер {hostel.ID}, з кімнати номер {room.ID}.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hostel.CalcProfit();
            }
        }

        private void bt_st_relocate_Click(object sender, EventArgs e)
        {
            string[] arrString = new string[3] // Заносимо значення з полів вводу в масив
            {
                tb_Record_ID.Text,
                tb_Room_num_1.Text,
                tb_Room_num_2.Text
            };
            if (StudentCheckingManager(3, out Student? student, out Room? room, out Room? room2, ref arrString)) // Перевірка на відповідність статі та наявності вільного місця в кімнаті
            {
                room.IDrecordBooks.Remove(tb_Record_ID.Text);
                room2.IDrecordBooks.Add(tb_Record_ID.Text);
                MessageBox.Show($"Студент з ідентифікатором залікової книжки: {student.IDrecordBook}, \nбув видалений з кімнати номер {room.ID} та поселений в кімнату номер {room2.ID}.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hostel.CalcProfit();
            }
        }

        private void bt_addStuff_Click(object sender, EventArgs e)
        {
            if (hostel is null)
            {
                MessageBox.Show($"Введіть номер гуртожитку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] arrString = new string[2]
            {
                tb_staff_name.Text,
                tb_staff_surname.Text
            };

            bool itn_ok = false;
            if (tb_staff_ITN.Text.Length != 0)
            {
                if (tb_staff_ITN.Text.Length != 10 || !int.TryParse(tb_staff_ITN.Text, out int num)) MessageBox.Show($"Перевірте правильність вводу ІПН!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (hostel.CheckArrayITNMatchingValues(tb_st_ID.Text)) MessageBox.Show($"Такий ІПН вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else itn_ok = true;
            }
            else itn_ok = true;

            if (CheckingStringInputValuesOnNull(arrString) && itn_ok)
            {
                Position position = new Position();
                if (rb_commendant.Checked) position = Position.Commandant;
                else if (rb_head_economic.Checked) position = Position.Head_of_economic_part;
                else if (rb_guard.Checked) position = Position.Guard;
                else if (rb_cleaner.Checked) position = Position.Cleaner;
                else MessageBox.Show($"Оберіть посаду!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                hostel.Workers.Add(new Worker(arrString, position, tb_staff_ITN.Text));
                
                MessageBox.Show($"Працівник по імені {tb_staff_surname.Text} {tb_staff_name.Text} та з ІПН: {hostel.Workers[^1].IndividualTaxNumber} \nбув успішно створений та доданий до гуртожитку № {hostel.ID}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gb_studentManager_Enter(object sender, EventArgs e)
        {

        }

        private void tb_st_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_st_patronymic_TextChanged(object sender, EventArgs e)
        {

        }

        private void CampusManagement_Load(object sender, EventArgs e)
        {

        }

        private void tb_Room_num_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_staff_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_guard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_head_economic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_6month_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
