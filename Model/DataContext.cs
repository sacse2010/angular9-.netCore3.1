using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Model
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
       
    }
}
