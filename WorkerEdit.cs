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
    public partial class WorkerEdit : Form
    {
        public WorkerEdit()
        {
            InitializeComponent();
        }


        SharovFrameDataSetTableAdapters.WorkerTableAdapter usersTableAdapter = new SharovFrameDataSetTableAdapters.WorkerTableAdapter();
        SharovFrameDataSet.WorkerDataTable dbuser;
        SharovFrameDataSet.WorkerRow rowWorker;

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewAccounts.Enabled = false;
            textbox_FirstName.Text = "";
            textbox_LastName.Text = "";
            textbox_MiddleName.Text = "";
            dtPickerBirthday.Value = new DateTime(1975, 1, 1);
            cbGenders.Text = "Мужской";
            maskedtbPhone.Text = "";
            this.groupBoxAccount.Enabled = true;
            this.buttonInsert.Enabled = true;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string first = textbox_FirstName.Text;
            string last = textbox_LastName.Text;
            string middle = textbox_MiddleName.Text;
            string phone = maskedtbPhone.Text;
            int gender;
            if (cbGenders.Text == "Мужской")
            {
                gender = 1;
            }
            else
            {
                gender = 2;
            }
            
            DateTime date = dtPickerBirthday.Value;

            if (String.IsNullOrEmpty(first) || String.IsNullOrEmpty(last) || String.IsNullOrEmpty(middle) || String.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            var filter = dbuser.Where(rec => rec.FirstName == first && rec.LastName == last && rec.MiddleName == middle && rec.Phone == phone && rec.Gender == gender && rec.DateBirth == date && rec.Phone == phone);
            if (filter.Count() == 0)
            {
                try
                {
                    usersTableAdapter.Insert(first, last, middle, gender, date, phone, false);
                    MessageBox.Show("Данные о новом пользователе успешно сохранены в БД");
                    WorkerEdit_Load(null, null);
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
            WorkerEdit_Load(null, null);
            dataGridViewAccounts.Enabled = true;
            textbox_FirstName.Text = "";
            textbox_LastName.Text = "";
            textbox_MiddleName.Text = "";
            dtPickerBirthday.Value = new DateTime(1975, 1, 1);
            cbGenders.Text = "Мужской";
            maskedtbPhone.Text = "";
            this.groupBoxAccount.Enabled = false;
            this.buttonInsert.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            dbuser = usersTableAdapter.GetData();
            var filter = dbuser.Where(rec => rec.Fired == false);
            int totalCount = filter.Count();
            this.dataGridViewAccounts.DataSource = filter.CopyToDataTable();
            this.dataGridViewAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccounts.Select();
            this.groupBoxAccount.Enabled = false;
            this.buttonInsert.Enabled = false;
        }

        private void dataGridViewAccounts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;
            textbox_FirstName.Text = dataGridViewAccounts.Rows[numRow].Cells[1].Value.ToString();
            textbox_LastName.Text = dataGridViewAccounts.Rows[numRow].Cells[2].Value.ToString();
            textbox_MiddleName.Text = dataGridViewAccounts.Rows[numRow].Cells[3].Value.ToString();
            dtPickerBirthday.Value = Convert.ToDateTime(dataGridViewAccounts.Rows[numRow].Cells[5].Value.ToString());
            cbGenders.Text = dataGridViewAccounts.Rows[numRow].Cells[4].Value.ToString();
            maskedtbPhone.Text = dataGridViewAccounts.Rows[numRow].Cells[6].Value.ToString();
            rowWorker = dbuser.FindByid(Convert.ToInt32(dataGridViewAccounts.Rows[numRow].Cells[0].Value.ToString()));
        }

    }
}
