using System.Drawing;
using System.Numerics;

namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 — Primary Constructor & Records
            //--------------Part 1 — Primary Constructor & Records---------------
            //Q2. In Main, create two Patient objects with the same values, then:
            var patient1 = new Patient(1, "Ahmed Mahmoud", "0111111111", "TestMedicalHistory");
            var patient2 = new Patient(1, "Ahmed Mahmoud", "0111111111", "TestMedicalHistory");

            //1. Print GetHashCode() of both. 
            Console.WriteLine(patient1.GetHashCode);
            Console.WriteLine(patient2.GetHashCode);
            //Are they equal? Why?
            //no ,because they have different refernces
            //2.Print patient01.Equals(patient02).

            Console.WriteLine(patient1.Equals(patient2));
            //.What is the result and why?
            //false, because Equals() Compare refrences not values and they have different references

            //3.Assign patient01 = patient02, then check Equals again.
            patient1 = patient2;
            Console.WriteLine(patient1.Equals(patient2));
            //What changed?
            //returns True
            //becuase the equal operator '=' assigned the patient2's reference to patient1




            //--------------------------------------------------
            Console.WriteLine("--------------------------------------------------");




            //Q3. Medical history is sensitive. Create a positional record PatientDto that exposes only: Id, FullName, PhoneNumber.
            //Repeat the comparisons from Q2 with two identical PatientDto objects.

            var patientDto1 = new PatientDto(1, "Ahmed Mahmoud", "0111111111");
            var patientDto2 = new PatientDto(1, "Ahmed Mahmoud", "0111111111");


            Console.WriteLine(patientDto1.GetHashCode);
            Console.WriteLine(patientDto2.GetHashCode);
            //Are they equal? Why?
            //yes ,because GetHashCode is overrided in record datetype and its calculated based on it's data not the reference

            Console.WriteLine(patientDto1.Equals(patientDto2));
            //.What is the result and why?
            //returns true
            //because Equals() in Record Type is overridden and it Compares values not refrences

            patientDto1 = patientDto2;
            Console.WriteLine(patientDto1.Equals(patientDto2));
            //returns True because 
            //becuase the equal operator '=' assigned the patientDto2's reference to patientDto1



            //--------------------------------------------------
            Console.WriteLine("--------------------------------------------------");



            //Create a static class PatientMapper with a static method MapFromModelToDto(Patient patient) that returns a
            //PatientDto.Use it in Main to convert a Patient and print the result.

            Patient patient = new(1, "Ahmed Ali", "01000000000", "TestData");

            Console.WriteLine("Before converting");
            Console.WriteLine(patient);

            PatientDto patientDto = PatientMapper.MapFromModelToDto(patient);

            Console.WriteLine("After converting");
            Console.WriteLine(patientDto);

            #endregion

            #region Part 2 — Singleton
            //Q6.In Main, call AppLogger.GetLogger() four times and print the GetHashCode() of each result.
            var logger1 = AppLogger.GetLogger();
            Console.WriteLine(logger1.GetHashCode());

            var logger2 = AppLogger.GetLogger();
            Console.WriteLine(logger2.GetHashCode());

            var logger3 = AppLogger.GetLogger();
            Console.WriteLine(logger3.GetHashCode());

            var logger4 = AppLogger.GetLogger();
            Console.WriteLine(logger4.GetHashCode());

            //What do you observe?
            // they all have the same hash code 
            //why? because we use the singlton design pattern which makes the instanses of
            //the class points to the same object in memory and prevents creating new object if there is already one


            #endregion

            #region Part 3 — var & dynamic
            //Declare a Patient using target-typed new(Patient p = new(...)).
            Patient p1 = new Patient(0, string.Empty, string.Empty, string.Empty);
            //2.Declare another Patient using var.
            var p2 = new Patient(0, string.Empty, string.Empty, string.Empty);

            //3.Declare a dynamic variable, assign a Patient to it, and print it.
            dynamic p3 = new Patient(0, string.Empty, string.Empty, string.Empty);
            Console.WriteLine(p3);
            //4.In a comment, explain the difference between var and dynamic:
            //when is each type resolved — compile time or run time ?
            //var : resolved at compile time, tells the compilor to detect the data type from the right hand so it needs to be initialized on the declaration
            //dynamic : is resolved at the run time so the compiler ignores it and the CLR detects the data type, so if the data type is not matching the actual vlaue it throws an exception
            #endregion

            #region Part 4 — Anonymous Types
            //Q8.Create two anonymous objects doctor01 and doctor02 with identical properties and values:
            var doctor01 = new {
                Name = "Sara",
                Specialty = "Cardiology",
                ExperienceYears = 8,
                Salary = 25_000
            };
            var doctor02 = new {
                Name = "Sara",
                Specialty = "Cardiology",
                ExperienceYears = 8,
                Salary = 25_000
            };
            //Then print:

            //1.doctor01.Name and doctor01.Specialty
            Console.WriteLine($"Name: {doctor01.Name}, Specialty: {doctor01.Specialty}");

            //2.GetHashCode() of both objects
            Console.WriteLine(doctor01.GetHashCode());
            Console.WriteLine(doctor02.GetHashCode());

            //3.doctor01.GetType()
            Console.WriteLine(doctor01.GetType());

            //4.doctor01.Equals(doctor02)
            Console.WriteLine(doctor01.Equals(doctor02));

            //5.doctor01.ToString()
            Console.WriteLine(doctor01.ToString());

            //In a comment, compare anonymous-type equality with class equality and record equality

            // anonymous type: == compares references but .Equals() compares values
            // so two separate objects with same values return true with .Equals()

            // class: both == and .Equals() compare references by default
            // need to override both manually to get value based equality

            // record: == and .Equals() both compare values automatically
            // no manual work needed, compiler handles it
            #endregion

            #region Part 5 — Extension Methods
            //Q10.In Main, call "Stethoscope".IsShorterThan(5) and "Ab".Repeat(4) and print the results.
            Console.WriteLine("Stethoscope".IsShorterThan(5));
            Console.WriteLine("Ab".Repeat(4));
            #endregion

            #region Part 6 — Unit Testing (xUnit)


            #endregion
        }
    }
}
