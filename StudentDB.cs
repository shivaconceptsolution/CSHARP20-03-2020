using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CodeFirstApproach
{
class StudentDB:DbContext
    {
        internal StudentDB():base()
        {
           // Database.SetInitializer<StudentDB>(new CreateDatabaseIfNotExists<StudentDB>());

        }

        public DbSet<Student> Students { get; set; }
    }
}
