using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7
{
    //Q3. Medical history is sensitive. Create a positional record PatientDto that exposes only: Id, FullName, PhoneNumber.

    public record PatientDto(int Id, string FullName, string PhoneNumber);
}
