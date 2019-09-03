using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Class1
    {
    }
    public class ClsDataLayer
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WIN8\source\repos\Threetierwebapplication\Threetierwebapplication\App_Data\Deploydatabse.mdf;Integrated Security=True");
        public void InsertData(string _name, string _city, string _email)
        {
            SqlDataAdapter SqlAdp = new SqlDataAdapter("Insert into UserTask1 values ('" + _name + "','" + _city + "','" + _email + "')", conn);
            DataTable DT = new DataTable();
            SqlAdp.Fill(DT);
        }
        public object SelectData()
        {
            SqlDataAdapter SqlAdp = new SqlDataAdapter("Select * from UserTask1", conn);
            DataTable DT = new DataTable();
            SqlAdp.Fill(DT);
            return DT;
        }

    }
    

    
}
