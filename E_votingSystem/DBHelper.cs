using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace E_votingSystem
{
    class DBHelper
    {
       static SqlConnection myConnection;
        static public void openConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\freeware sys\documents\visual studio 2013\Projects\E_votingSystem\E_votingSystem\MyDatabase.mdf;Integrated Security=True";

            myConnection = new SqlConnection(connectionString);
            //MessageBox.Show(System.Configuration.ConfigurationManager.ConnectionStrings["Database"].ToString());
            //myConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database"].ToString();
            try
            {
                myConnection.Open();
                MessageBox.Show("Database is open");
                
            }
            catch(SqlException er)
            {
                MessageBox.Show("Error in Database :"+er.Message);

            }


        }

        static public void insertIntoUser(User person)
        {
            openConnection();
            string sql = "insert into Users(firstName, lastName, phone, email, ssn, address, education, vottingId, PhotoPath, bdate)values ('" + person.FirstName + "','" + person.LastName + "','" + person.Phone + "','" + person.Email + "','" + person.Ssn + "' ,'" + person.Address + "','" + person.Education + "','" + person.VottingId + "','" + person.PhotoPath1 + "','" + person.Bdate + "')";
            SqlCommand command = new SqlCommand(sql, myConnection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data inserted ");

            }
            catch (SqlException a)
            {
                MessageBox.Show(a.Message);
            }

            myConnection.Close();
        }
        static public void insertIntoCandidate(Candidate person)
        {
            openConnection();
            string sql = "insert into Candidate(Name, Address, Phone, E-mail, Photo, ssn)values ('" + 
                person.Name + "','" + person.Address + "','" + person.Phone + "','" + person.EMail1 + "','" +
                person.Photo + "' ,'" + person.Ssn + "')";
            
            SqlCommand command = new SqlCommand(sql, myConnection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data inserted ");

            }
            catch (SqlException a)
            {
                MessageBox.Show(a.Message);
            }

            myConnection.Close();
        }
        static public void insertIntoVotes(Vote v)
        {
            openConnection();
            string sql = "insert into Votes(C_id, U_id)values ('" + v.Candidate_Id + "','" + v.User_Id + "')";
            SqlCommand command = new SqlCommand(sql, myConnection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data inserted ");

            }
            catch (SqlException a)
            {
                MessageBox.Show(a.Message);
            }

            myConnection.Close();
        }

        static public User selectUserByVotionId(string id)
        {
            User u=null;

            openConnection();
            string sql = "select * from Users where vottingId ='" + id + "'";
            SqlCommand command = new SqlCommand(sql, myConnection);

            SqlDataReader data = command.ExecuteReader();

            while(data.Read())
            {
                u= new User();
                u.FirstName = data["firstName"].ToString(); //get first name from result table from database 
                u.LastName = data["lastName"].ToString();
                u.Ssn = data["ssn"].ToString();
                u.VottingId = id;
                u.Phone = data["phone"].ToString();
                u.Address = data["address"].ToString();
                u.Bdate = data["bdate"].ToString();
                u.Education = data["education"].ToString();
                u.PhotoPath1 = data["PhotoPath"].ToString();
                u.Email = data["email"].ToString();
            }

            myConnection.Close();
            return u;
        }

    }
}
