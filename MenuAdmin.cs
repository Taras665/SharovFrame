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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button_UserEdit_Click(object sender, EventArgs e)
        {
            UserEdit x = new UserEdit();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button_History_Click(object sender, EventArgs e)
        {
            History x = new History();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
