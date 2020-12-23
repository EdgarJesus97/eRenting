using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace eRenting.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Empresa> Empresa { get; set; }   
        public DbSet<Funcionario> Funcionario { get; set; }

        public DbSet<Veiculo> Veiculo { get; set; }
        
        public DbSet<Combustivel> Combustivel { get; set; }
        
        public DbSet<CategoriaVeiculo> CategoriaVeiculo { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Entrega> Entrega { get; set; }

        public DbSet<Recebimento> Recebimento { get; set; }

        public DbSet<StatusReserva> StatusReserva { get; set; }

        public DbSet<Reserva> Reserva { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}