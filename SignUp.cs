using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CRM
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SignUp" in both code and config file together.
    public class SignUp : ISignUp
    {
        public string create_account(Model.Users Users)
        {
            //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            using (SqlConnection con = new SqlConnection(@"Data Source=LAWRULER-SAHIL\SQL2017; Initial Catalog=CRM;Integrated Security=False;User Id=sa; Password=Clean123!@#; Min Pool Size=0;Max Pool Size=1500;Pooling=true; MultipleActiveResultSets=true"))
            {
                using (SqlCommand cmd = new SqlCommand(@"Insert into Users (UserEmail, UserPassword, CreateDateTime, IsActive) 
                        values (@UserEmail, @UserPassword, @CreateDateTime, 1)", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@UserEmail", Users.UserEmail);
                    cmd.Parameters.AddWithValue("@UserPassword", Users.UserPassword);
                    cmd.Parameters.AddWithValue("@CreateDateTime", System.DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Account created successfully";
        }
    }
}
