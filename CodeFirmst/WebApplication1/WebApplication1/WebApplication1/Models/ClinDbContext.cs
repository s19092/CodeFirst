using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ClinDbContext : DbContext
    {

        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Person> People { get; set; }

        public ClinDbContext() { }
        public ClinDbContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder mb)
        {

            base.OnModelCreating(mb);

            var clist = new List<Client>();
            clist.Add(new Client
            {

                Id = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                Birthdate = DateTime.Now

            });
            clist.Add(new Client
            {

                Id = 2,
                FirstName = "dzban",
                LastName = "walski",
                Birthdate = DateTime.Now

            });

            var dlist = new List<Doctor>();
            dlist.Add(new Doctor
            {

                Id = 3,
                FirstName = "qram",
                LastName = "wqas",
                Email = "małpa@@.com"

            });
            dlist.Add(new Doctor
            {

                Id = 4,
                FirstName = "qrqweeqw",
                LastName = "wqaasdsadadss",
                Email = "małpfqfwqwfwqfqfw@fqfwq.con"

            });

            var mlist = new List<Medicament>();
            mlist.Add(new Medicament
            {

                IdMedicament = 1,
                Name = " jADWQd",
                Description = "XDASD",
                Type = "PLOX"
            });
            mlist.Add(new Medicament
            {

                IdMedicament = 2,
                Name = " jADWQDQ2QWR13131313d",
                Description = "XDAS12121212121212D",
                Type = "PLO121212121212X"
            });

            mb.Entity<Client>().HasData(clist);
            mb.Entity<Doctor>().HasData(dlist);
            mb.Entity<Medicament>().HasData(mlist);



        }


    }




}
