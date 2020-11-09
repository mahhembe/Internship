using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    class Results
    {
        private static SqlConnection conn = new SqlConnection("Data Source= DESKTOP-O7ODQH8\\SQLEXPRESS; Initial Catalog=Internship;Integrated Security=true;");
        private static SqlCommand cmd = new SqlCommand();
        //private static string totalSurvey,averageAge, oldAge,youngAge;
        private static string percentPizza, percentPasta, percentWors;
        private static string averageEatOut, averageMovie, averageTV, averageRadio;
        
        
        
        private static string getData(string a)
        {
            string results="";
            cmd.CommandText = a;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                results = dr.GetValue(0).ToString();
            
            }
            conn.Close();
            return results;
            
        
        }

        public static string TotalSurvey 
        {

            get { return getData("select count(*) from Personal"); }
        }
        public static string AverageAge 
        {
            get { return getData("select avg(Age)from Personal"); }
        }
        public static string OlderAge 
        {
            get { return getData("select max(Age) from Personal"); }
        }
        public static string YoungerAge 
        {
            get { return getData("select min(Age) from Personal"); }
        }
        public static string PercentPizza 
        {
            get{

                double totalPizza = double.Parse(getData("select count(Pizza) from Food"));
                double likePizza = double.Parse(getData("select count(Pizza) from Food where pizza='yes'"));
                return (likePizza / totalPizza) * 100 + "";
            
            }
        
        }
        public static string PercentPasta
        {
            get
            {

                double totalPasta = double.Parse(getData("select count(Pasta) from Food"));
                double likePasta = double.Parse(getData("select count(Pasta) from Food where Pasta='yes'"));
                return (likePasta / totalPasta) * 100 + "";

            }

        }
        public static string PercentPap
        {
            get
            {

                double totalPap = double.Parse(getData("select count(Pap) from Food"));
                double likePap = double.Parse(getData("select count(Pap) from Food where Pap='yes'"));
                return (likePap / totalPap) * 100 + "";

            }

        }
        public static string AverageEeatOut 
        {
            get { return getData("select avg(Question1) from questions"); }
        }
        public static string AverageMovie
        {
            get { return getData("select avg(Question2) from questions"); }
        }
        public static string AverageTV
        {
            get { return getData("select avg(Question3) from questions"); }
        }
        public static string AverageRadio
        {
            get { return getData("select avg(Question4) from questions"); }
        }
       
    }
}
