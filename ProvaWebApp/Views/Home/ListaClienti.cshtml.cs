using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProvaWebApp.Models;
using System.Data.SqlClient;

namespace ProvaWebApp.Views.Home
{
    public class ListaClientiModel : PageModel
    {
        public List<Cliente> clienti = new List<Cliente>();
        public async void OnGet()
        {
            try
            {
                string query = string.Empty;
                string connectionString = "Data Source=(localdb)\\DBTest;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string path = Path.Combine(Environment.CurrentDirectory, "QuerySQL", "SelectClienti.sql");
                    using (StreamReader reader = new StreamReader(path))
                    {
                        query = reader.ReadToEnd();
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente();
                                cliente.Name = reader.GetString(0);
                                cliente.Cognome = reader.GetString(1);
                                cliente.Eta = reader.GetInt32(2);
                                cliente.Piva = reader.GetString(3);
                                cliente.ColoreCapelli = reader.GetString(4);
                                clienti.Add(cliente);
                            }

                        }
                    }
                    connection.Close();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    
    }
}
