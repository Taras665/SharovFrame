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
    public partial class UserEdit : Form
    {
        public UserEdit()
        {
            InitializeComponent();
        }
        SharovFrameDataSetTableAdapters.UserTableAdapter usersTableAdapter = new SharovFrameDataSetTableAdapters.UserTableAdapter();
        SharovFrameDataSet.UserDataTable dbuser;
        SharovFrameDataSet.UserRow rowRunner;
        int newuser = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewAccounts.Enabled = false;
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            newuser = 1;
            buttonDelete.Enabled = false;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string log = textBoxLogin.Text;
            string pas = textBoxPassword.Text;

            if (String.IsNullOrEmpty(log) || String.IsNullOrEmpty(pas))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }            

            var filter = dbuser.Where(rec => rec.Login == log && rec.Password == pas);
            if (filter.Count() == 0 && newuser == 1)
            {
                try
                {
                    usersTableAdapter.Insert(log, pas, 2);
                    MessageBox.Show("Данные о новом пользователе успешно сохранены в БД");
                    UserEdit_Load(null, null);
                }
                catch
                {
                    MessageBox.Show("При добавлении нового пользователя возникли проблемы");
                    return;
                }
            }
            else if (newuser == 0)
            {
                try
                {
                    rowRunner.IdRole = 2;
                    rowRunner.Login = textBoxLogin.Text;
                    rowRunner.Password = textBoxPassword.Text;
                    usersTableAdapter.Update(rowRunner);
                    MessageBox.Show("Данные о пользователе успешно сохранены в БД");

                }
                catch
                {
                    MessageBox.Show("При добавлении нового пользователя возникли проблемы");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован в системе." +
                                                                    Environment.NewLine + " Введите другие данные");
                return;
            }
            UserEdit_Load(null, null);
            dataGridViewAccounts.Enabled = true;
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            newuser = 0;
            buttonDelete.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            dbuser = usersTableAdapter.GetData();
            var filter = dbuser.Where(rec => rec.IdRole == 2);
            int totalCount = filter.Count();
            this.dataGridViewAccounts.DataSource = filter.CopyToDataTable();
            this.dataGridViewAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccounts.Select();
            int newuser = 0;

        }

        private void dataGridViewAccounts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;
            textBoxLogin.Text = dataGridViewAccounts.Rows[numRow].Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridViewAccounts.Rows[numRow].Cells[2].Value.ToString();
            rowRunner = dbuser.FindByid(Convert.ToInt32(dataGridViewAccounts.Rows[numRow].Cells[0].Value.ToString()));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Delete(rowRunner.id, rowRunner.Login, rowRunner.Password, rowRunner.IdRole);
            MessageBox.Show("");
            UserEdit_Load(null, null);
        }
    }
}
