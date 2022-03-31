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
    public partial class Form1 : Form
    {
        public Form1()
        {            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.database5DataSet.Пользователи);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.пользователиTableAdapter.Fill(this.database5DataSet.Пользователи);
            string textLogin = login.Text;
            string password = pass.Text;
            if(database5DataSet.Пользователи.FindByLogin(textLogin) != null)
            {
               if (this.database5DataSet.Пользователи.FindByLogin(textLogin).Password == password)
               {
                    Frm2 form2 = new Frm2();
                    form2.user = textLogin;
                    if (database5DataSet.Пользователи.FindByLogin(textLogin).Admin == true)
                    {
                        form2.admin = true;
                    }
                    form2.Show();
               }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = true;
            adminCheck.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(login.Text != "" && pass.Text != "")
            {
                string newLogin = login.Text;
                string newPass = pass.Text;
                bool newAdmin = adminCheck.Checked;
                this.пользователиTableAdapter.Insert(newLogin, newPass, newAdmin);
                button3.Visible = false;
                adminCheck.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
            }
        }
    }
}
