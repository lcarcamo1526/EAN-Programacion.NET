using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Employees.ViewModel
{
    public class ProyectConnection
    {
        private static SqlConnection conn = null;

        public static SqlConnection Conn { get => conn; set => conn = value; }

        /// <summary>
        /// Make the connecting between the domain host using Sql server
        /// </summary>
        /// <param name="source">Domain host</param>
        /// <param name="user">user </param>
        /// <param name="password">password</param>
        public void Connect(string source, string user, string password) {
           var path = string.Format("Data Source={0};Initial Catalog=Northwind;User ID={1};Password={2}", source, user, password);
            Conn = new SqlConnection(path);
            Conn.Open();
        }

      
    }
}
