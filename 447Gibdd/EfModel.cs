using _447Gibdd.Classes.Entities;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System.Data.Entity;

namespace _447Gibdd
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EfModel : DbContext
    {
        private static EfModel instance;
        public static EfModel Init() {
            if (instance == null) {
                instance = new EfModel();
            }
            return instance;
        }
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_447Gibdd.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public EfModel()
            : base("server=192.168.201.12;port=3306;user id=ISP333_StoliarovID;password=I%!L96D86;database=ISP333_StoliarovID_Gibdd447s;characterset=utf8")
        {

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
    }


    //public class MyEntity
    //{
        //public int Id { get; set; }
        //public string Name { get; set; }
    //}
}