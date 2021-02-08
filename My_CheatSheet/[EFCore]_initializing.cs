//create class that derives after DbContext
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}

//in startup cs
services.AddDbContext<AppDbContext>(opt => 
opt.UseSQLServer(connstring)));