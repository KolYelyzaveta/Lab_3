using Lab_2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {         
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти?", "Вихід", buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes) Application.Exit();
        }

        private void bt_CreateHostel_Click(object sender, EventArgs e)
        {
            Hide();
            CreationHostel newHostel = new CreationHostel();
            newHostel.Show();
        }

        private void bt_hostelManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            CampusManagement manageStudents = new CampusManagement();
            manageStudents.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            Campus.WritingInFiles();
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            Campus.ReadingFromFiles();
        }
    }
}
