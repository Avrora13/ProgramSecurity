using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramSecurity
{
    public partial class Frm2 : Form
    {
        public string user;
        public bool admin;
        public Frm2()
        {
            InitializeComponent();
        }

        private void Frm2_Load(object sender, EventArgs e)
        {
            nameUser.Text = user;
            if (admin != true)
            {
                this.dataGridView1.ReadOnly = true;
                this.passwordDataGridViewTextBoxColumn.Visible = false;
                this.adminDataGridViewCheckBoxColumn.Visible = false;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.database5DataSet.Пользователи);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.пользователиTableAdapter.FillBy(this.database5DataSet.Пользователи);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
