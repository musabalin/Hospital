using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
  public  class HospitalContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=Hospital;Trusted_Connection=true");
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Clinic> Clinics{ get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
