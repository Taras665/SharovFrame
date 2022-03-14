using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharovFrame
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        SharovFrameDataSetTableAdapters.LoginHistoryTableAdapter LoginHistoryTableAdapter = new SharovFrameDataSetTableAdapters.LoginHistoryTableAdapter();
        SharovFrameDataSetTableAdapters.UserTableAdapter usersTableAdapter = new SharovFrameDataSetTableAdapters.UserTableAdapter();
        SharovFrameDataSet.UserDataTable dbuser;


        private void SinglIn()
        {
            string log, pas;
            pas = textBox_Password.Text;
            log = textBox_Login.Text;
            DateTime dt = DateTime.Now;
            string timeString = dt.ToLongTimeString();
            dbuser = usersTableAdapter.GetData();
            var filter = dbuser.Where(x => x.Login == log && x.Password == pas);
            if (filter.Count() != 0)
            {
                ClassTotal.idRole = filter.ElementAt(0).IdRole;
                ClassTotal.login = filter.ElementAt(0).Login;
                ClassTotal.id = filter.ElementAt(0).id;
                try
                {
                    LoginHistoryTableAdapter.Insert(log, TimeSpan.Parse(timeString), true);
                }
                catch
                {
                    MessageBox.Show("Вход выполнен");
                }
                switch (ClassTotal.idRole)
                {
                    case 1:     //admin
                        MessageBox.Show("Вы успешно авторизовались как админ.");
                        MenuAdmin rl1 = new MenuAdmin();
                        Hide();
                        rl1.ShowDialog();
                        Show();
                        break;
                    case 2:     //HR
                        Menu rl2 = new Menu();
                        Hide();
                        rl2.ShowDialog();
                        Show();
                        break;
                }

            }
            else
            {
                MessageBox.Show("Логин или пароль неверный");
                textBox_Login.Clear();
                textBox_Password.Clear();
                try
                {
                    LoginHistoryTableAdapter.Insert(log, TimeSpan.Parse(timeString), false);
                }
                catch
                {
                    MessageBox.Show("Ошибка в истории входа");
                }
            }
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SinglIn();
            }
        }

        private void SighIn_Click(object sender, EventArgs e)
        {
            SinglIn();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                textBox_Password.PasswordChar = '*';
            else
                textBox_Password.PasswordChar = '\0';

        }
    }
}
