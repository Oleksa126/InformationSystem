using InformationSystem.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InformationSystem.DAL
{
    public class ClientRepository
    {
        public static string ConnectionString = "Server=OLEKSA; Database=informationSystem; Integrated Security=True;";

        public bool addClient(string login, string password, string firstName, string lastName, string phoneNumber, string city, string email)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();


            string Query = "INSERT INTO [dbo].[Client]([passwordClient], [loginClient], [firstName], [lastName], [email], [phoneNumber], [city])" +
                "VALUES" +
                "('" + password + "', " +
                "'" + login + "', " +
                "'" + firstName + "', " +
                "'" + lastName + "', " +
                "'" + email + "', " +
                "'" + phoneNumber + "', " +
                "'" + city + "')";
            SqlCommand sqlCommand = new SqlCommand(Query, con);
            sqlCommand.ExecuteNonQuery();

            con.Close();

            return true;
        }

        public bool deleteClientById(int id)
        {

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "delete [dbo].[Client] where idClient = '" + id + "'";

            SqlCommand sqlCommand = new SqlCommand(Query, con);
            sqlCommand.ExecuteNonQuery();

            con.Close();

            return true;
        }

        public bool updateClientById(string login, string password, string firstName, string lastName, string phoneNumber, string city, string email, int id)
        {

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "UPDATE [dbo].[Client]  SET " +
                "[firstName] = '" + firstName + "', " +
                "[lastName] = '" + lastName + "'," +
                "[phoneNumber] = '" + phoneNumber + "', " +
                "[loginClient] = '" + login + "', " +
                "[passwordClient] = '" + password + "'," +
                "[email] = '" + email + "'," +
                "[city] = '" + city + "'" +
                "WHERE [idClient] = '" + id + "'";
            SqlCommand sqlCommand = new SqlCommand(Query, con);
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return true;
        }

        public List<Client> getAllClient()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "select " +
                "[idClient], " +
                "[passwordClient], " +
                "[loginClient], " +
                "[firstName], " +
                "[lastName], " +
                "[email]," +
                "[phoneNumber], " +
                "[city] " +
                "from [dbo].[Client]";

            SqlCommand sqlCommand = new SqlCommand(Query, con);
            SqlDataReader sqlData = sqlCommand.ExecuteReader();

            List<Client> client = new List<Client>();
            while (sqlData.Read())
            {
                client.Add(new Client()
                {
                    idClient = sqlData.GetInt32(sqlData.GetOrdinal("idClient")),
                    firstName = sqlData.GetString(sqlData.GetOrdinal("firstName")),
                    lastName = sqlData.GetString(sqlData.GetOrdinal("lastName")),
                    phoneNumber = sqlData.GetString(sqlData.GetOrdinal("phoneNumber")),
                    email = sqlData.GetString(sqlData.GetOrdinal("email")),
                    city = sqlData.GetString(sqlData.GetOrdinal("city")),
                    loginClient = sqlData.GetString(sqlData.GetOrdinal("loginClient")),
                    passwordClient = sqlData.GetString(sqlData.GetOrdinal("passwordClient")),
                });
            }

            con.Close();

            return client;
        }

        public SqlDataAdapter getClientById(int id)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT [idClient], " +
                "[passwordClient], " +
                "[loginClient]," +
                "[firstName], " +
                "[lastName], " +
                "[email], " +
                "[phoneNumber], " +
                "[city] " +
                "from [dbo].[Client] " +
                "WHERE [idClient] = '" + id + "'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, con);

            con.Close();
            return dataAdapter;
        }

        public SqlDataAdapter innerJoin()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query =
    "SELECT [dbo].[Administrator].[loginAdmin], " +
    "[dbo].[ClientStatement].[price], " +
    "[dbo].[Contractor].city, " +
    "[dbo].[Contractor].nameConstractor, " +
    "[dbo].[Client].city, " +
    "[dbo].[Client].firstName, " +
    "[dbo].[Client].lastName," +
    "[dbo].[Client].phoneNumber " +
    "FROM [dbo].[ConsiderationOfProposals] inner join[dbo].[Administrator] " +
    "on " +
    "[dbo].[Administrator].idAdmin = [dbo].[ConsiderationOfProposals].idAdmin " +
    "inner join[dbo].[ClientStatement] " +
    "on " +
    "[dbo].[ConsiderationOfProposals].idClientStatement = [dbo].[ClientStatement].[idClientStatement] " +
    "inner join[dbo].[Offer] " +
    "on " +
    "[dbo].[ConsiderationOfProposals].idOffer  = [dbo].[Offer].idOffer " +
    "inner join[dbo].[Contractor] on [dbo].[Offer].idContractor = [dbo].[Contractor].idContractor " +
    "inner join[dbo].[Client] on [dbo].[ClientStatement].idClient = [dbo].[Client].idClient";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, con);
            con.Close();
            return dataAdapter;

        }

        public SqlDataAdapter leftJoin() {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT " +
                "[dbo].[Client].city, " +
                "[dbo].[Client].email, " +
                "[dbo].[Client].firstName, " +
                "[dbo].[Client].lastName, " +
                "[dbo].[Client].loginClient, " +
                "[dbo].[Client].passwordClient, " +
                "[dbo].[Client].phoneNumber, " +
                "[dbo].[ClientStatement].price, " +
                "[dbo].[ClientStatement].stateOfClientStatement " +
                "FROM" +
                "[dbo].[ClientStatement] LEFT JOIN[dbo].[Client] " +
                "ON " +
                "[dbo].[ClientStatement].[idClient] = [dbo].[Client].[idClient]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, con);
            con.Close();
            return dataAdapter;
        }

        public SqlDataAdapter rightJoin()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT " +
                "[dbo].[Client].city, " +
                "[dbo].[Client].email, " +
                "[dbo].[Client].firstName, " +
                "[dbo].[Client].lastName, " +
                "[dbo].[Client].loginClient, " +
                "[dbo].[Client].passwordClient, " +
                "[dbo].[Client].phoneNumber, " +
                "[dbo].[ClientStatement].price, " +
                "[dbo].[ClientStatement].stateOfClientStatement " +
                "FROM" +
                "[dbo].[ClientStatement] RIGHT JOIN[dbo].[Client] " +
                "ON " +
                "[dbo].[ClientStatement].[idClient] = [dbo].[Client].[idClient]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, con);
            con.Close();
            return dataAdapter;
        }

        public SqlDataAdapter threeCon() {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "select " +
                "[dbo].[Client].[firstName]," +
                "[dbo].[Client].[lastName]," +
                "[dbo].[Client].[city]," +
                "[dbo].[ConstuctionWork].[typeOfWork]," +
                "[dbo].[ConstuctionWork].[shortDescription]" +
                "from[dbo].[ClientStatement] " +
                "inner join" +
                "[dbo].[Client]" +
                "on" +
                "[dbo].[ClientStatement].[idClient]=[dbo].[Client].[idClient] " +
                "inner join" +
                "[dbo].[Works]" +
                "on" +
                "[dbo].[Works].[idClientStatement] = [dbo].[ClientStatement].[idClientStatement]" +
                "inner join" +
                "[dbo].[ConstuctionWork]on[dbo].[ConstuctionWork].[idConstuctionWork] = [dbo].[Works].[idConstuctionWork]";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, con);
            con.Close();
            return dataAdapter;
        }
    }
}
