using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_EF.EF_Model
{
    internal class DataBaseContext : DbContext
    {
        public DataBaseContext(string connectingString)
            : base(connectingString)
        { }

        public DataBaseContext(string dataSource, string initialCatalog, string userId, string userPassword)
            : base($@"Data Source={dataSource};Initial Catalog={initialCatalog};User ID={userId};Password={userPassword};integrated security=False;MultipleActiveResultSets=True;")
        {
        }



        public DbSet<Shipment> Shipments { get; set; }
    }
}
