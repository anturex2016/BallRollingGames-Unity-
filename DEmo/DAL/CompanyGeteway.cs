using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;
using DEmo.Model;

namespace DEmo.DAL
{
    public class CompanyGeteway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["StockMenagementBDconnectionString"].ConnectionString;
        public int SaveCompany(Company company)
        {   
           

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Company_t VALUES('" + company.CompanyName + "')";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected;
        }

        public List<Company> GetAllCompany()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Company_t";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Company> company = new List<Company>();
            while (reader.Read())
            {
                Company acompany = new Company();
                acompany.CompanyID = (int)reader["CompanyID"];
                acompany.CompanyName = reader["CompanyName"].ToString();

                company.Add(acompany);
            }
            reader.Close();
            connection.Close();
            return company;
        }

        public Company IsExist(Company company)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Company_t WHERE CompanyName='" + company.CompanyName + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Company aCompany = null;
            while (reader.Read())
            {
                aCompany = new Company();
                aCompany.CompanyID = (int)reader["CompanyID"];
                aCompany.CompanyName = reader["CompanyName"].ToString();

            }
            reader.Close();
            connection.Close();
            return aCompany;
        }
    }
}