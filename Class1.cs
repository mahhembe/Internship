using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
namespace WindowsFormsApplication3
{
    class Class1
    {
        /*  private string[] personal = new string[5];
          private string[] food = new string[6];
          private string[] question = new string[4];    */
   

        private ArrayList Personal = new ArrayList();
        private ArrayList Food = new ArrayList();
        public int[] question=new int[4];
        private SqlConnection conn = new SqlConnection("Data Source= DESKTOP-O7ODQH8\\SQLEXPRESS; Initial Catalog=Internship;Integrated Security=true;");
        private SqlCommand cmd = new SqlCommand();

        public Class1() 
        {
            for (int i = 0; i < 4;i++ )
            {
                question[i] = 0;

            }
        
        
        }


        public void storePersonalToDatabase() 
        {
         
         int age = int.Parse( Personal[4].ToString());
          cmd.CommandText = "insert into Personal values ('" + Personal[0] + "','" + Personal[1] + "','" + Personal[2] + "', sysdatetime(),"+age+")";  
        cmd.Connection = conn;
        conn.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        Personal.Clear();
        conn.Close();
        
       
        }

        public void StoreFoodToDatabase() 
        {
            cmd.CommandText = "insert into Food values ('" + Food[0] + "','" + Food[1] + "','" + Food[2] + "','" + Food[3] + "','" + Food[4] + "','" + Food[5] + "')"; 
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Food.Clear();
            conn.Close();
        
        
        }


        public void StoreQuestionToDatabase()
        {
            cmd.CommandText = "insert into questions values (" + question[0] + "," + question[1] + "," + question[2] + "," + question[3] + ")";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Food.Clear();
            conn.Close();


        }



        public string InputPerson
        {
            set { Personal.Add(value); }
        
        }

        public string InputFood 
        {
            set { Food.Add(value); }
        }

       
      

         
    }

   
}
