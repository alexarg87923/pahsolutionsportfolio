using MySql.Data.MySqlClient;
using pahsolutionsportfolio.Models;

namespace DatabaseAccess {
    public class DatabaseAccess
    {
        private readonly string connectionString = string.Format("server={0};database={1};user={2};password={3};", 
        Environment.GetEnvironmentVariable("SERVER"),
        Environment.GetEnvironmentVariable("DB_NAME"),
        Environment.GetEnvironmentVariable("DB_USER"),
        Environment.GetEnvironmentVariable("DB_PASSWORD")
        );

        public void DeleteContactFormSubmission(int id)
        {
            using var connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string sql = $"DELETE FROM {Environment.GetEnvironmentVariable("TABLE_NAME")} where id=@value1";
                using var command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@value1", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        public void SaveContactFormSubmission(ContactViewModel formData)
        {
            using var connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string sql = $"INSERT INTO {Environment.GetEnvironmentVariable("TABLE_NAME")} (field, name, email, description, nda) values (@value1, @value2, @value3, @value4, @value5)";
                using var command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@value1", formData.SelectedField);
                command.Parameters.AddWithValue("@value2", formData.Name);
                command.Parameters.AddWithValue("@value3", formData.Email);
                command.Parameters.AddWithValue("@value4", formData.Description);
                command.Parameters.AddWithValue("@value5", formData.IsNDARequired);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        public List<ContactViewModel> GetContactFormSubmission()
        {
            List<ContactViewModel> allFormSubmissions = [];
            using var connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string sql = $"SELECT * FROM {Environment.GetEnvironmentVariable("TABLE_NAME")}";
                using var cmd = new MySqlCommand(sql, connection);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var formSubmission = new ContactViewModel
                    {
                        ID = Convert.ToInt32(reader["id"])!,
                        SelectedField = reader["field"].ToString()!,
                        Name = reader["name"].ToString()!,
                        Email = reader["email"].ToString()!,
                        Description = reader["description"].ToString()!,
                        IsNDARequired = Convert.ToBoolean(reader["nda"])
                    };

                    allFormSubmissions.Add(formSubmission);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }

            return allFormSubmissions;
        }
    }

}
