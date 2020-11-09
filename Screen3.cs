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
    public partial class Screen3 : Form
    {
        public Screen3()
        {
            InitializeComponent();
           
        }

        private void OkB_Click(object sender, EventArgs e)
        {
            Screen3.ActiveForm.Close();
        }

        private void Screen3_Load(object sender, EventArgs e)
        {
            NumOfSurveyTB.Text = Results.TotalSurvey;
            AcgAge.Text = Results.AverageAge;
            OldestAgeTB.Text = Results.OlderAge;
            YoungestAgeTB.Text = Results.YoungerAge;
            PizzaTB.Text = Results.PercentPizza;
            PastaTB.Text = Results.PercentPasta;
            PapTB.Text = Results.PercentPap;
            EatOutTB.Text = Results.AverageEeatOut;
            MovieTB.Text = Results.AverageMovie;
            TVTB.Text = Results.AverageTV;
            RadioTB.Text = Results.AverageRadio;
        }
    }
}
