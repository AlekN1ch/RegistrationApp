using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationApp
{
    public partial class Form3 : Form
    {
        public int yerSt,progn;

        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prognozirDataSet.prognTable". При необходимости она может быть перемещена или удалена.
            this.prognTableTableAdapter.Fill(this.prognozirDataSet.prognTable);
            yerSt=Form2.yearStonks;
            label2.Text = yerSt.ToString();
            progn = yerSt / 12;
            label4.Text=progn.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
