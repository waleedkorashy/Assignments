using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare_System.Entities
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Specialization { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
