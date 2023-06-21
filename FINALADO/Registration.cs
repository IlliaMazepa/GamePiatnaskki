using FINALADO.DBclasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALADO
{
    public partial class Registration : Form
    {
        Users users = new Users();
        int index;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            users.Load();
            int a = 0;
            foreach(DataRow row in users.ds.Tables["Users"].Rows)
            {
                if (row[1].ToString().Trim() == tbLog.Text && tbPas.Text == row[2].ToString().Trim())
                {
                    a = 1;
                    
                    Form1 form1 = new Form1(users, Convert.ToInt32(row[0]));
                    this.Visible = false;
                    form1.Show();
                    break;
                }
            }
            if (a == 0)
            {
                MessageBox.Show("Wrong Password or Login\n Try again");
               
            }
        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            users.Load();
            SignUp signUp = new SignUp(users);
            this.Visible = false;
            signUp.Show();
        }
    }
}
