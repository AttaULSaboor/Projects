using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment1
{
	public partial class _Default : Register
	{
		protected void Registers(object sender, EventArgs e)
		{

		}
        /// <summary>
        /// Method called on click of Submit button. This method use get highest person id from person table then insert the person record
        /// in the table.
        /// </summary>
        /// <param name="sender">page</param>
        /// <param name="e">event data</param>
        protected void submitButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                DateTime.TryParse(birthDateTextBox.Text, out DateTime date);
                TimeSpan tm = (DateTime.Now - date);
                int age = (tm.Days / 365);
                if (age >= 18)
                {
                    try
                    {
                        var connectionString = WebConfigurationManager.ConnectionStrings["HASCConnectionString"].ConnectionString;
                        using (var connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(
                              "SELECT Max(person_id) as personid FROM persons;",
                              connection);
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            int personid = 0;
                            while (reader.Read())
                            {
                                personid = (int)reader["personid"];
                            }
                            reader.Close();

                            command = new SqlCommand("INSERT INTO persons  VALUES(@person_id, @first_name, @last_name, @division_id,@email,@birth_date)", connection);
                            command.Parameters.Add("@person_id", System.Data.SqlDbType.Int);
                            command.Parameters["@person_id"].Value = personid + 1;
                            command.Parameters.Add("@first_name", System.Data.SqlDbType.VarChar);
                            command.Parameters["@first_name"].Value = firstNameTextBox.Text;
                            command.Parameters.Add("@last_name", System.Data.SqlDbType.VarChar);
                            command.Parameters["@last_name"].Value = lastNameTextBox.Text;
                            command.Parameters.AddWithValue("@division_id", divisionsDropDownList.SelectedValue);
                            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                            command.Parameters["@email"].Value = EmailTextBox.Text;
                            command.Parameters.Add("@birth_date", System.Data.SqlDbType.Date).Value = date.ToShortDateString();
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        outputLiteral.Text += $"<p class=\"alert alert-danger\" >{ex.Message}</p>";
                    }

                    outputLiteral.Text = "<p class=\"alert alert-success\" >Thank you for your interest.The club will be in touch shortly. </p>";
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    EmailTextBox.Text = "";
                    divisionsDropDownList.SelectedIndex = 0;
                    birthDateTextBox.Text = "";
                }

                else
                {
                    outputLiteral.Text = "<p class=\"alert alert-danger\" >You must be atleast 18 years of age to join the club.</p>";
                    birthDateTextBox.Focus();
                }
            }
        }
    }
}