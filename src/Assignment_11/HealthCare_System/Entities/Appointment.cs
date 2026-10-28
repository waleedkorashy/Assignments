using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare_System.Entities
{
    internal class Appointment
    {
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public DateOnly AppointmentDate { get; set; }
    }
}
