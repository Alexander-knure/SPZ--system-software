using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPZ7
{
    
    public partial class Form1 : Form
    {
        SqlConnection sqlconnection;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alex2\source\repos\_SPZ7_\SPZ7\Database1.mdf;Integrated Security=True";

            sqlconnection = new SqlConnection(conStr);
            await sqlconnection.OpenAsync();
            SqlDataReader reader = null;
            
            SqlCommand command = new SqlCommand("SELECT * from [Employees]", sqlconnection);
            try
            {
                reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(reader["Id"])+" "+
                                       Convert.ToString(reader["Name"]) + " " +
                                       Convert.ToString(reader["Age"]) + " " +
                                       Convert.ToString(reader["Salary"]) + " " +
                                       Convert.ToString(reader["Premium"]) + " " +
                                       Convert.ToString(reader["Email"]) + " " +
                                       Convert.ToString(reader["Dep_Id"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            SqlCommand command2 = new SqlCommand("SELECT * from [Department]", sqlconnection);
            try
            {
                reader = await command2.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    listBox2.Items.Add(Convert.ToString(reader["Id"]) + " " +
                                       Convert.ToString(reader["Name"]) + " " +
                                       Convert.ToString(reader["Location"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlconnection != null && sqlconnection.State != ConnectionState.Closed)
                sqlconnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlconnection != null && sqlconnection.State != ConnectionState.Closed)
                sqlconnection.Close();
        }

        private async void EMP_INSERT_OK_Click(object sender, EventArgs e)
        {
            if (label22.Visible)
                label22.Visible = false;

            if (!string.IsNullOrEmpty(NameSet.Text) && !string.IsNullOrWhiteSpace(NameSet.Text) &&
                !string.IsNullOrEmpty(PhoneSet.Text) && !string.IsNullOrWhiteSpace(PhoneSet.Text) &&
                !string.IsNullOrEmpty(EmailSet.Text) && !string.IsNullOrWhiteSpace(EmailSet.Text) &&
                Dep_IdSET.Value != 0)
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Employees](Name,Age,Salary,Premium,PhoneNumber,Email,Dep_Id)" +
                                                 "Values(@Name,@Age,@Salary,@Premium,@PhoneNumber,@Email,@Dep_Id)",sqlconnection);

                command.Parameters.AddWithValue("Name", NameSet.Text);
                command.Parameters.AddWithValue("Age", AgeSet.Value);
                command.Parameters.AddWithValue("Salary", SalarySet.Value);
                command.Parameters.AddWithValue("Premium", PremiumSet.Value);
                command.Parameters.AddWithValue("PhoneNumber", PhoneSet.Text);
                command.Parameters.AddWithValue("Email", EmailSet.Text);
                command.Parameters.AddWithValue("Dep_Id", Dep_IdSET.Value);

                await command.ExecuteNonQueryAsync();
                NameSet.Clear();
                AgeSet.Value = 20;
                SalarySet.Value = 5000;
                PremiumSet.Value = 0;
                PhoneSet.Clear();
                EmailSet.Clear();
                Dep_IdSET.Value = 0;
            }
            else
            {
                label22.Visible = true;
                label22.Text = "поля введены не коректно";
            }
        }
        private async void DEP_ISERT_OK_Click(object sender, EventArgs e)
        {
            if (label23.Visible)
                label23.Visible = false;

            if (!string.IsNullOrEmpty(DepNameSet.Text) && !string.IsNullOrWhiteSpace(DepNameSet.Text) &&
                !string.IsNullOrEmpty(DepLocSet.Text) && !string.IsNullOrWhiteSpace(DepLocSet.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Department](Name,Location)Values(@Name, @Location)", sqlconnection);

                command.Parameters.AddWithValue("Name", DepNameSet.Text);
                command.Parameters.AddWithValue("Location", DepLocSet.Text);
                await command.ExecuteNonQueryAsync();
                DepLocSet.Clear();
                DepNameSet.Clear();
            }
            else
            {
                label23.Visible = true;
                label23.Text = "поля введены не коректно";
            }
        }
        private async void workerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            SqlDataReader reader = null;

            SqlCommand command = new SqlCommand("SELECT * from [Employees]", sqlconnection);
            try
            {
                reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(reader["Id"]) + " " +
                                       Convert.ToString(reader["Name"]) + " " +
                                       Convert.ToString(reader["Age"]) + " " +
                                       Convert.ToString(reader["Salary"]) + " " +
                                       Convert.ToString(reader["Premium"]) + " " +
                                       Convert.ToString(reader["Email"]) + " " +
                                       Convert.ToString(reader["Dep_Id"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            SqlCommand command2 = new SqlCommand("SELECT * from [Department]", sqlconnection);
            try
            {
                reader = await command2.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    listBox2.Items.Add(Convert.ToString(reader["Id"]) + " " +
                                       Convert.ToString(reader["Name"]) + " " +
                                       Convert.ToString(reader["Location"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void DEP_ISERT_CANCEL_Click(object sender, EventArgs e)
        {
            DepLocSet.Clear();
            DepNameSet.Clear();
            label23.Visible = false;
        }

        private void EMP_ISERT_CANCEL_Click(object sender, EventArgs e)
        {
            NameSet.Clear();
            AgeSet.Value = 20;
            SalarySet.Value = 5000;
            PremiumSet.Value = 0;
            PhoneSet.Clear();
            EmailSet.Clear();
            Dep_IdSET.Value = 0;
            label22.Visible = false;
        }

        private async void EMP_UPDATE_OK_Click(object sender, EventArgs e)
        {
            if (label25.Visible)
                label25.Visible = false;

            if (!string.IsNullOrEmpty(Name_Update.Text) && !string.IsNullOrWhiteSpace(Name_Update.Text) &&
                !string.IsNullOrEmpty(ID_UPDATE.Text) && !string.IsNullOrWhiteSpace(ID_UPDATE.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Employees] SET [Name]=@Name, " +
                    "[Age]=@Age,[Salary]=@Salary,[Premium]=@Premium,[PhoneNumber]=@phoneNumber," +
                    "[Email]=@Email,[Dep_Id]=@Dep_Id WHERE [Id]=@Id", sqlconnection);
                command.Parameters.AddWithValue("Id", ID_UPDATE.Text);
                command.Parameters.AddWithValue("Name", Name_Update.Text);
                command.Parameters.AddWithValue("Age", Age_Update.Value);
                command.Parameters.AddWithValue("Salary", Salary_Update.Value);
                command.Parameters.AddWithValue("Premium", Premium_Update.Value);
                command.Parameters.AddWithValue("PhoneNumber", PhoneNumber_Update.Text);
                command.Parameters.AddWithValue("Email", Email_Update.Text);
                command.Parameters.AddWithValue("Dep_Id", DepID_Update.Text);

                await command.ExecuteNonQueryAsync();
                ID_UPDATE.Clear();
                NameSet.Clear();
                Age_Update.Value = 20;
                Salary_Update.Value = 5000;
                Premium_Update.Value = 0;
                PhoneNumber_Update.Clear();
                Email_Update.Clear();
                DepID_Update.Value=1;
            }
            else if (string.IsNullOrEmpty(ID_UPDATE.Text) && string.IsNullOrWhiteSpace(ID_UPDATE.Text))
            {
                label25.Visible = true;
                label25.Text = "идентификатор должен быть заполнен ";
            }
            else
            {
                label25.Visible = true;
                label25.Text = "поля введены не коректно";
            }
        }

        private async void DEP_UPDATE_OK_Click(object sender, EventArgs e)
        {
            if (label26.Visible)
                label26.Visible = false;

            if (!string.IsNullOrEmpty(DEP_NAME_UPDATE.Text) && !string.IsNullOrWhiteSpace(DEP_NAME_UPDATE.Text) &&
                !string.IsNullOrEmpty(DEP_LOC_UPDATE.Text) && !string.IsNullOrWhiteSpace(DEP_LOC_UPDATE.Text) &&
                !string.IsNullOrEmpty(DEP_ID_UPDATE.Text) && !string.IsNullOrWhiteSpace(DEP_ID_UPDATE.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Department] SET [Name]=@Name, [Location]=@Location " +
                    "WHERE [Id]=@Id", sqlconnection);
                command.Parameters.AddWithValue("Id", DEP_ID_UPDATE.Text);
                command.Parameters.AddWithValue("Name", DEP_NAME_UPDATE.Text);
                command.Parameters.AddWithValue("Location", DEP_LOC_UPDATE.Text);

                await command.ExecuteNonQueryAsync();
                DEP_ID_UPDATE.Clear();
                DEP_NAME_UPDATE.Clear();
                DEP_LOC_UPDATE.Clear();
            }
            else if (string.IsNullOrEmpty(DEP_ID_UPDATE.Text) && string.IsNullOrWhiteSpace(DEP_ID_UPDATE.Text))
            {
                label26.Visible = true;
                label26.Text = "идентификатор должен быть заполнен ";
            }
            else
            {
                label26.Visible = true;
                label26.Text = "поля введены не коректно";
            }
        }


        private async void DEL_WOR_Click(object sender, EventArgs e)
        {
            if (label27.Visible)
                label27.Visible = false;

            if (!string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text))
            {
                int err;
                string str = "DELETE FROM [Employees] WHERE [Id]=" + textBox7.Text;
                SqlCommand command = new SqlCommand(str, sqlconnection);
                try
                {
                    err= await command.ExecuteNonQueryAsync();
                    await command.ExecuteNonQueryAsync();
                    if (err > 0)
                    {
                        MessageBox.Show("Delete successful");
                    }
                    else
                    {
                        MessageBox.Show("Error:Id does not Exist");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                textBox7.Clear();
            }
            else
            {
                label27.Visible = true;
                label27.Text = "идентификатор должен быть заполнен ";
            }
        }

        private async void DEL_DEP_Click(object sender, EventArgs e)
        {
            if (label28.Visible)
                label28.Visible = false;

            if (!string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text))
            {
                

                string str1 = "DELETE FROM [Department] WHERE [Id]=" + textBox8.Text;
                string str2 = "DELETE FROM [Employees] WHERE [Dep_Id]=" + textBox8.Text;
                int err1, err2;

                SqlCommand command1 = new SqlCommand(str1, sqlconnection);
                SqlCommand command2 = new SqlCommand(str2, sqlconnection);


                try
                {
                    try
                    {

                        err1 = await command2.ExecuteNonQueryAsync();
                        await command2.ExecuteNonQueryAsync();
                        if (err1 > 0)
                        {
                            MessageBox.Show("Worker delete successful");
                        }
                        else
                        {
                            MessageBox.Show("Error:Id does not Exist");
                        }
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message);

                    }
                    err2 = await command1.ExecuteNonQueryAsync();
                    await command1.ExecuteNonQueryAsync();
                    if (err2 > 0)
                    {
                        MessageBox.Show("Department delete successful");
                    }
                    else
                    {
                        MessageBox.Show("Error:Id does not Exist");
                    }
                    textBox8.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                label28.Visible = true;
                label28.Text = "идентификатор должен быть заполнен ";
            }
        }
    }
    
}
