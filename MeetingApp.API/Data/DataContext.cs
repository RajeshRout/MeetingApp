using MeetingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options){}
        public DbSet<Value> Values { get; set; }
        //public DbSet<User> Users { get; set; }        
    }
}
/* Notes on DataContext class:
1. DataContext: Bridge between DB and App (DB creation/Connections/CRUD). 
   DataContext inherits DbContext (part of Microsoft.EntityFrameworkCore) features.
   DataContext registered under ConfigureServices in Startup.cs with a 
   ConnectionDetails for the DB so to be usable by application. ConnectionDetails
   are configured in appsettings.json
2. Role of constructor DataContext: ??
3. DbSet: EF creates tables in DB(entity created as classes- AKA tables)
4. 
*/