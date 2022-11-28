using MAUI_Wannabe.Models;
using Microsoft.EntityFrameworkCore;

namespace MAUI_Wannabe.Data
{
    public class MyDBContext :  DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> option) : base(option){

        }
        public DbSet<Player> players { get; set; } 
    }
}
