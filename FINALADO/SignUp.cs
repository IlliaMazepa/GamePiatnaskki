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
    public partial class SignUp : Form
    {
        Users Users=null;
        public SignUp(Users users)
        {
            InitializeComponent();
            Users=users;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null && tbPAs.Text != null)
            {
                DataRow dataRow = Users.ds.Tables["Users"].NewRow();
                dataRow.ItemArray = new object[] { Users.ds.Tables["Users"].Rows.Count, tbName.Text.ToString(), tbPAs.Text.ToString() };
                Users.ds.Tables["Users"].Rows.Add(dataRow);

                Users.INS($"INSERT INTO Users (Login,Password) VALUES ('{tbName.Text}','{tbPAs.Text}')");
                
                Form1 form1 = new Form1(Users, Convert.ToInt32(Users.ds.Tables["Users"].Rows.Count-1));
                this.Visible = false;
                form1.Show();
            }
        }
    }
}
