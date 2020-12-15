using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

using System.Configuration;
//Sql staff
using System.Data.SqlClient;
using System.Data.SqlTypes;

//
using System.Data;
//using System.Data.Entity;

namespace WpfApp1
{
    class DataBaseConnector:DbContext
    {
        
        public DbSet<LicenseKey> Keys { get; set; }  
    
              


        public DataBaseConnector(string dataBase)
        {


            Database.EnsureCreated();     
            

            
        }

       

        internal void Insert(string v)
        {
            
            
        }

        internal bool Had(string text)
        {
            return text=="trial";   
        }

        protected override void OnConfiguring(DbContextOptionsBuilder
          optionsBuilder)
        {
            string connectionStringBuilder = new SqliteConnectionStringBuilder()
            {
                DataSource = "LicenseDb.db"
            }.ToString();



            var connection = new SqliteConnection(connectionStringBuilder);
            optionsBuilder.UseSqlite(connection);
        }
       
          
        
    }
}
