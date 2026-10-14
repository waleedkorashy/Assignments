using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment_7
{
    public static class PatientMapper
    {
        public static PatientDto MapFromModelToDto(Patient patient) =>
                    new(patient.Id, patient.FullName, patient.PhoneNumber);

    }
}
