using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7
{
    public class Patient(int id, string fullName, string phoneNumber, string medicalHistory)
    {
        //i had to expose the properties to access them in PatientMapper
        public int Id { get; } = id;
        public string FullName { get; } = fullName;
        public string PhoneNumber { get; } = phoneNumber;
        public string MedicalHistory { get; } = medicalHistory;

        public override string ToString()
        {
            return $"ID: {Id}, FullName: {FullName}, PhoneNumber: {PhoneNumber}, MedicalHistory: {MedicalHistory}";
        }
    }
}
