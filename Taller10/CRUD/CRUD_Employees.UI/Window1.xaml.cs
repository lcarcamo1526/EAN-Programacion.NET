using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using CRUD_Employees.ViewModel;


namespace CRUD_Employees.UI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

       
        public Window1()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, RoutedEventArgs e)
        {

            ProyectConnection proyectConnection = new ProyectConnection();
            SqlCommand comm = new SqlCommand();

            try
            {
                proyectConnection.Connect(dbname.Text, usernam_db.Text, txtPassword.Password);
                comm.Connection = ProyectConnection.Conn;
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
                this.Close();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Please check the domain name, user and password, if the problem persist restart Sql server or Visual Studio");
                try
                {
                    ProyectConnection.Conn.Close();
                    this.Close();

                }
                catch (System.Exception)
                {

                    this.Close();
                }
                
            }
            

           


            
            
            
            











        }
    }
}
