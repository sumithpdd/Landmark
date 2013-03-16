using System.Data.Linq;
using Asos.DailyEdit.Wp8.DomainModel;

namespace Landmark.Dev4Good.WP.Classes
{
    public class DbContext : DataContext
    { 

          public Table<Category> Categories; 
         
        /// <summary>
        /// Initializes a new instance of the <see cref="DbContext"/> class.
        /// </summary>
        /// <param name="connectionString">
        /// The connection string.
        /// </param>
        public DbContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}