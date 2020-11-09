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
    public partial class Screen1 : Form
    {
       
        public Screen1()
        {
            InitializeComponent();
        }
        
     
        private void SurveyB_Click(object sender, EventArgs e)
        {
            Screen2 s2 = new Screen2();
            s2.Show();
        }

        private void ResultsB_Click(object sender, EventArgs e)
        {
            Screen3 s3 = new Screen3();
            s3.Show();
        }
    }
}
