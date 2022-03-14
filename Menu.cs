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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_WorkerOrder_Click(object sender, EventArgs e)
        {
            WorkerOrder x = new WorkerOrder();
            Hide();
            x.ShowDialog();
            Show();
        }
    

        private void button_WorkerEdit_Click(object sender, EventArgs e)
        {
            WorkerEdit x = new WorkerEdit();
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
