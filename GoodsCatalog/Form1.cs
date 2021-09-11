using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Configuration;
using GoodsCatalog.Models;

namespace GoodsCatalog
{
    public partial class Form1 : Form
    {
        string connectingString;
        SqlConnection connection;
        List<Category> categories;
        List<Producer> producers;
        List<Product> products;


        public Form1()
        {
            InitializeComponent();
            connectingString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectingString);
            
            categories = new List<Category>();
            producers = new List<Producer>();
            products = new List<Product>();
        }
        private string GetHash(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();
        }
        private void Auth()
        {
            LoginWindow loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                string login = loginWindow.Login;
                string password = loginWindow.Password;
                password = GetHash(password);

                string sqlQuery = $"select Login, Password from Users where Login='{login}' and Password='{password}'";
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    var row = reader.Read();

                    if (row)
                    {
                        MessageBox.Show("Вы успешно авторизованы", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка выполнения",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }

            }
        }

        private void LoadCategories()
        {
            try
            {
                string query = $"select * from Categories";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                categoryBox.Items.Clear();
                categories.Clear();
                
                while (reader.Read())
                {
                    Category category = new Category() { Id = (int)reader["Id"], Name = reader["Name"].ToString() };
                    categoryBox.Items.Add(category);
                    categories.Add(category);
                }
                categoryBox.DisplayMember = "Name";
                categoryBox.ValueMember = "Id";
                if (categoryBox.Items.Count > 0)
                {
                    categoryBox.SelectedIndex = 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка загрузки категорий",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void LoadProducers()
        {
            try
            {
                string query = $"select * from Producers";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                producerBox.Items.Clear();
                producers.Clear();

                while (reader.Read())
                {
                    Producer producer = new Producer() { Id = (int)reader["Id"], Name = reader["Name"].ToString() };
                    producerBox.Items.Add(producer);
                    producers.Add(producer);
                }
                producerBox.DisplayMember = "Name";
                producerBox.ValueMember = "Id";

                if (producerBox.Items.Count > 0)
                {
                    producerBox.SelectedIndex = 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка загрузки производителей",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void LoadProducts()
        {
            try
            {
                string query = $"select * from Products";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                productsListView.Items.Clear();
                products.Clear();

                while (reader.Read())
                {
                    Product product = new Product() { 
                        Id = (int)reader["Id"], 
                        Name = reader["Name"].ToString(),
                        CategoryId = (int)reader["CategoryId"],
                        ProducerId = (int)reader["ProducerId"],
                        Price = (decimal)reader["Price"],
                        Count = (int)reader["Count"],
                        Measure = reader["Measure"].ToString(),
                        Expire = (DateTime)reader["Expire"],
                        Delivery = reader["Delivery"].ToString()
                    };
                    var item = productsListView.Items.Add(product.Name);
                    item.SubItems.Add(product.Price.ToString("F"));
                    item.SubItems.Add(product.Count.ToString());
                    item.SubItems.Add(product.Measure);
                    item.SubItems.Add(product.Expire.ToShortDateString());
                    item.SubItems.Add(product.Delivery);
                    products.Add(product);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка загрузки товаров",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Auth();
            LoadCategories();
            LoadProducers();
            LoadProducts();

        }

        private void createCatItem_Click(object sender, EventArgs e)
        {
            CategoriesEditor categoriesEditor = new CategoriesEditor();
            categoriesEditor.OperationTitle = "Добавление категории";
            categoriesEditor.ButtonTitle = "Добавить категорию";
            categoriesEditor.Categories = categories;
            if(categoriesEditor.ShowDialog() == DialogResult.OK)
            {
                // Для избежания sql-инъекций запрещено подставлять значения переменных 
                // прямо в строку запроса => для этого следует использовать специальные параметры
                // (параметризованые запросы) !!!
                string query = $"insert into Categories (Name) values (@p1)";

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = categoriesEditor.CategoryName;
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Категория успешно добавлена", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCategories();
            }
        }

        private void updateCatItem_Click(object sender, EventArgs e)
        {
            CategoriesEditor categoriesEditor = new CategoriesEditor();
            categoriesEditor.OperationTitle = "Редактирование категории";
            categoriesEditor.ButtonTitle = "Изменить категорию";
            categoriesEditor.Categories = categories;

            categoriesEditor.CategoryName = (categoryBox.SelectedItem as Category).Name;
            int id = (categoryBox.SelectedItem as Category).Id;

            if (categoriesEditor.ShowDialog() == DialogResult.OK)
            {
                // Для избежания sql-инъекций запрещено подставлять значения переменных 
                // прямо в строку запроса => для этого следует использовать специальные параметры
                // (параметризованые запросы) !!!
                string query = $"update Categories set Name=@p1 where Id=@p2";

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = categoriesEditor.CategoryName;
                cmd.Parameters.Add("@p2", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Категория успешно изменена", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCategories();
            }
        }

        private void deleteCatItem_Click(object sender, EventArgs e)
        {
            CategoriesEditor categoriesEditor = new CategoriesEditor();
            categoriesEditor.OperationTitle = "Удаление категории";
            categoriesEditor.ButtonTitle = "Удалить категорию";
            categoriesEditor.Categories = categories;

            categoriesEditor.CategoryName = (categoryBox.SelectedItem as Category).Name;
            int id = (categoryBox.SelectedItem as Category).Id;

            if (categoriesEditor.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Для избежания sql-инъекций запрещено подставлять значения переменных 
                    // прямо в строку запроса => для этого следует использовать специальные параметры
                    // (параметризованые запросы) !!!
                    string query = $"delete from Categories where Id=@p1";

                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@p1", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();


                    connection.Close();
                    MessageBox.Show("Категория успешно удалена", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCategories();
                    LoadProducts();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибкак при удалении категории",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if(connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
                
            }
        }
    }
}
