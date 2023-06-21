using FINALADO.DBclasses;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALADO
{
    public partial class Form1 : Form
    {
        Users Users;
        List<Button> Buttons;
        List<int> tempINT = null;
        string Qarr = null;
        string Barr = null;
        int IndofQ = 0;
        int stat = 0;
        int IndOfPl=0;
        double prs = 0;
        int total=0;
        public Form1(Users users, int index)
        {
            InitializeComponent();
            Users = users;
            IndOfPl=index;

            Buttons = new List<Button>();
            Buttons.Add(btn1);
            Buttons.Add(btn2);
            Buttons.Add(btn3);
            Buttons.Add(btn4);
            Buttons.Add(btn5);

            foreach (Button item in Buttons)
            {
                item.BackColor = Color.Gray;
                item.Visible = true;
                
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Qarr = Rand(1, Users.ds.Tables["QA"].Rows.Count);
            QuestionShow();

        }

        void QuestionShow()
        {

            //lblQuestion.Text = Convert.ToInt32(Qarr[0]-49).ToString();
            // - 1
            //Users.ds.Tables["QA"].Rows[Convert.ToInt32(Qarr[0]) - 49].ItemArray.Length
            try
            {
                if (Convert.ToInt32(Users.ds.Tables["QA"].Rows[Convert.ToInt32(Qarr[IndofQ]) - 49].ItemArray[0]) == 4)
                {
                    pbQ.Visible = true;
                    pbQ.Image = Image.FromFile(@"E:\VSProjects\FINALADO\FINALADO\Images\Tank.jpg");
                    pbQ.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbQ.Visible = false;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            



            if (Convert.ToInt32(Users.ds.Tables["QA"].Rows[Convert.ToInt32(Qarr[IndofQ]) - 49].ItemArray[0]) == 3) total += 4;

            else total += Convert.ToInt32(Users.ds.Tables["QA"].Rows[Convert.ToInt32(Qarr[IndofQ]) - 49].ItemArray[0]);

            lblQuestion.Text = Users.ds.Tables["QA"].Rows[Convert.ToInt32(Qarr[IndofQ]) - 49].ItemArray[1].ToString();
            ButtonChecker(Convert.ToInt32(Qarr[IndofQ]) - 49);

        }


        string Rand(int first,int second)
        {
            int tempM;
            Random random = new Random();
            tempINT = new List<int>();
            string str = null;

            for (int i = 0; i < second;)
            {
                tempM = random.Next(first, second + 1);
                if (tempINT.Count != 0 && tempINT.Contains(tempM))
                {

                }
                else
                {
                    i++;
                    tempINT.Add(tempM);
                }
            }
            foreach (int i in tempINT)
            {
                str += i.ToString();
            }
           return str;
        }


        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button button;
            if (sender is Button)
            {
                button = sender as Button;
                if (button.BackColor == Color.Gray)
                {
                    button.BackColor = Color.Green;
                }
                else
                {
                    button.BackColor = Color.Gray;
                }
            }
            
        }

        void ButtonChecker(int am)
        {
            foreach (Button item in Buttons)
            {
                item.BackColor = Color.Gray;
                item.Visible = true;
            }
            int num = 0;
            string str = Users.ds.Tables["QA"].Rows[am].ItemArray[1].ToString();
            string str2 = Users.ds.Tables["QA"].Rows[am].ItemArray[6].ToString();
            for (int i = 0; i < 7; i++)
            {
                if (Users.ds.Tables["QA"].Rows[am].ItemArray[i].ToString() != "") num++;
            }
            for (int i = 4; i >= num-2; i--)
            {
                Buttons[i].Visible = false;
            }
            Barr = Rand(1, num - 2);
            for (int i = 2,j=0; i < num+2; i++,j++)
            {
                try
                {
                    Buttons[Convert.ToInt32(Barr[j]) - 49].Text = Users.ds.Tables["QA"].Rows[am].ItemArray[i].ToString();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
                int IndTemp=0;
            foreach(DataRow row in Users.ds.Tables["QA"].Rows)
            {
                if (lblQuestion.Text == row.ItemArray[1].ToString()) IndTemp = Convert.ToInt32(row.ItemArray[0]) - 1;
            }
            foreach(Button item in Buttons)
            {
                if (IndTemp == 2 && item.BackColor == Color.Green)
                {
                    if(item.Text.Trim()== Users.ds.Tables["QA"].Rows[IndTemp].ItemArray[2].ToString().Trim()|| item.Text.Trim() == Users.ds.Tables["QA"].Rows[IndTemp].ItemArray[3].ToString().Trim())
                    stat += 2;
                    else
                    {
                        stat -= 1;
                    }
                }
                else if (item.BackColor == Color.Green )
                {
                    if(item.Text.Trim() == Users.ds.Tables["QA"].Rows[IndTemp].ItemArray[2].ToString().Trim())
                    {
                        stat += Convert.ToInt32(Users.ds.Tables["QA"].Rows[IndTemp].ItemArray[0]);
                        
                        
                    }
                    else
                    {
                        stat -= 1;
                    }

                }
            }
            IndofQ += 1;
            if (IndofQ >= 0 && IndofQ < Users.ds.Tables["QA"].Rows.Count) QuestionShow();
            else
            {
                prs = Convert.ToDouble(stat) / Convert.ToDouble(total);
                prs=Math.Round(prs,2);
               
                MessageBox.Show($"Result is {stat} FROM {total}");
                if (prs*100 >= 70) GenS();
                
                    if (MessageBox.Show("Do you want to restart?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else Application.Exit();
                
            }
            
        }
        void GenS()
        {
            string name="";
            foreach(DataRow row in Users.ds.Tables["Users"].Rows)
            {
                if (Convert.ToInt32(row[0])==IndOfPl) name= row[1].ToString();
            }
            Close();    
            Sertificate s = new Sertificate(name,Convert.ToInt32(prs*100));
            s.Show();
        }
    }

    


    
}
