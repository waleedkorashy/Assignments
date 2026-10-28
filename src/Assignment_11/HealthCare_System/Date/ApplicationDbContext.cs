using HealthCare_System.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare_System.Date
{
    internal class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=.;Database=HealtCareDb;Trusted_Connection=True;TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasKey(p => p.Id);
            modelBuilder.Entity<Doctor>().HasKey(d => d.Id);
            modelBuilder.Entity<Appointment>().HasKey(a => new { a.PatientId, a.DoctorId});
            modelBuilder.Entity<Appointment>().HasOne(a => a.Patient)
                                              .WithMany(p => p.Appointments);
            modelBuilder.Entity<Appointment>().HasOne(a => a.Doctor)
                                              .WithMany(p => p.Appointments);
            

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
