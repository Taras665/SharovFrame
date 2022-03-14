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
    public partial class History : Form
    {
        SharovFrameDataSet.LoginHistoryDataTable dataLoginHistory;
        SharovFrameDataSetTableAdapters.LoginHistoryTableAdapter LoginHistoryTableAdapter = new SharovFrameDataSetTableAdapters.LoginHistoryTableAdapter();

        public History()
        {
            InitializeComponent();
        }

        string inputtype;
        int count;
        string check = null;

        private void History_Load(object sender, EventArgs e)
        {
            dataLoginHistory = LoginHistoryTableAdapter.GetData();
            dataGridView.DataSource = dataLoginHistory;
            dataGridView.Columns["IDHis"].Visible = false;

            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = String.Format("ResultLogin = true", inputtype);
            count = dataGridView.RowCount;
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = String.Format("ResultLogin = false or ResultLogin = true", check);
            tbCount.Text = "Сумма успешных входов: " + count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputtype = (string)comboBox1.Text;
            switch (inputtype)
            {
                case "Все":
                    inputtype = null;
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter = String.Format("ResultLogin = false or ResultLogin = true", inputtype);
                    break;
                case "Успешный":
                    inputtype = "true";
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter = String.Format("ResultLogin = true", inputtype);
                    break;
                case "Неуспешный":
                    inputtype = "false";
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter = String.Format("ResultLogin = false", inputtype);
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
