using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Coursework.Models
{
	public class ClinicContext: IdentityDbContext<IdentityUser>
	{
		public ClinicContext(DbContextOptions<ClinicContext> options): base(options) { }

		public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}