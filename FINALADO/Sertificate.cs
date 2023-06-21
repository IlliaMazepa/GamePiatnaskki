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
    public partial class Sertificate : Form
    {
        public Sertificate(string name,int stat)
        {
            InitializeComponent();
            lblName.Text = name.Trim();
            lblScore.Text += stat;
        }
    }
}
