using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Screen2 : Form
    {
        private bool personalEntered;
        private bool foodEntered;
        private bool questionsAnswered;

        Class1 c = new Class1();
        public Screen2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                PersonInput();
                FoodInput();
                questionCheck();
            if(questionsAnswered && foodEntered && personalEntered )
            {
                c.storePersonalToDatabase();
                c.StoreFoodToDatabase();
                c.StoreQuestionToDatabase();
                MessageBox.Show(null,"Thank you for completing the survey","Successfully submitted");
                ClearAll();
            }
        }
        public void ClearAll() 
        {
            SurnameTB.Clear();
            FNameTB.Clear();
            CNumberTB.Clear();
            DateTB.Clear();
            AgeTB.Clear();
            PizzaCB.Checked = false;
            PastaCB.Checked = false;
            PapCB.Checked = false;
            ChickenCB.Checked = false;
            BeefCB.Checked = false;
            OtherCB.Checked = false;
            
        
        }


        public void questionCheck() 
        {
            questionsAnswered = false;
            if (c.question[0]!=0 && c.question[1] != 0 && c.question[2] != 0 && c.question[3] != 0)
            {
                questionsAnswered = true;

            }
            else
   
                MessageBox.Show(null,"please fill all questions","error");
            
            
        
        
        }



        private void PersonInput()
        {
            
            
                personalEntered=false;
                c.InputPerson = SurnameTB.Text;
                c.InputPerson = FNameTB.Text;
                c.InputPerson = CNumberTB.Text;
                c.InputPerson = DateTB.Text;
                c.InputPerson = AgeTB.Text;
                if (SurnameTB.Text != "" && FNameTB.Text != "" && CNumberTB.Text != "" && DateTB.Text != "")
                {
                    try { int a=int.Parse(AgeTB.Text);
                    if (a < 5 || a > 125) { MessageBox.Show(null,"You cannot be older than 125 and younger than 5 years old",""); }
                    else
                    {
                        personalEntered = true;
                    }
                    }
                    catch { MessageBox.Show(null, "please enter  valid AGE", "ERROR"); }

                }
                else { MessageBox.Show(null,"plese enter all your personal information","ERROR"); }
           
        }


       private void FoodInput()
       {
           foodEntered = false;
           if (PizzaCB.Checked)
           { c.InputFood = "yes";
           foodEntered = true;
           }
           else
               c.InputFood = "no";
           if (PastaCB.Checked)
           {
               c.InputFood = "yes";
               foodEntered = true;
           }
           else
               c.InputFood = "no";
           if(PapCB.Checked)
           {   c.InputFood="yes";
               foodEntered = true;
           }
           else 
               c.InputFood="no";
           if(ChickenCB.Checked)
           {  c.InputFood="yes";
               foodEntered = true;
           }
           else
               c.InputFood="no";
           if(BeefCB.Checked)
           {   c.InputFood="yes";
               foodEntered = true;
           }
           else
               c.InputFood="no";
           if (OtherCB.Checked)
           { c.InputFood = "yes";
               foodEntered = true;
           }
           else
               c.InputFood = "no";
           if (foodEntered == false) { MessageBox.Show(null, "Please enter your favourite food", "ERRO MESSAGE"); }
       
       
       }

      

       private void Eat_SA_CheckedChanged(object sender, EventArgs e)
       {
           c.question[0] = 1;

       }

       private void Eat_A_CheckedChanged(object sender, EventArgs e)
       {
           c.question[0] = 2;
       }

       private void Eat_N_CheckedChanged(object sender, EventArgs e)
       {
           c.question[0] = 3;
       }

       private void Eat_D_CheckedChanged(object sender, EventArgs e)
       {
           c.question[0] = 4;
       }

       private void Eat_SD_CheckedChanged(object sender, EventArgs e)
       {
           c.question[0]=5;
       }

       private void Movie_SA_CheckedChanged(object sender, EventArgs e)
       {
           c.question[1] = 1;
       }

      

       private void Movie_A_CheckedChanged(object sender, EventArgs e)
       {
           c.question[1] = 2;

       }

       private void TV_SA_CheckedChanged(object sender, EventArgs e)
       {
           c.question[2] = 1;
       }

       private void Movie_N_CheckedChanged(object sender, EventArgs e)
       {
           c.question[1] = 3;
       }

       private void TV_A_CheckedChanged(object sender, EventArgs e)
       {
           c.question[2] = 2;
       }

       private void Movie_D_CheckedChanged(object sender, EventArgs e)
       {
           c.question[1] = 4;

       }

       private void Movie_SD_CheckedChanged(object sender, EventArgs e)
       {
           c.question[1] = 5;
       }

       private void TV_N_CheckedChanged(object sender, EventArgs e)
       {
           c.question[2] = 3;
       }

       private void TV_D_CheckedChanged(object sender, EventArgs e)
       {
           c.question[2] = 4;
       }

       private void TV_SD_CheckedChanged(object sender, EventArgs e)
       {
           c.question[2] = 5;
       }

       private void Radio_SA_CheckedChanged(object sender, EventArgs e)
       {
           c.question[3] = 1;
       }

       private void Radio_A_CheckedChanged(object sender, EventArgs e)
       {
           c.question[3] = 2;
       }

       private void Radio_N_CheckedChanged(object sender, EventArgs e)
       {
           c.question[3] =3;
       }

       private void Radio_D_CheckedChanged(object sender, EventArgs e)
       {
           c.question[3] =4;
       }

       private void Radio_SD_CheckedChanged(object sender, EventArgs e)
       {
           c.question[3] = 5;
       }

       private void Screen2_Load(object sender, EventArgs e)
       {

       }

       private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
       {
           DateTB.Text=dateTimePicker1.Text;
       }

       
    }
}
