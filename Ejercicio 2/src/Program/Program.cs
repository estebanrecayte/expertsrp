using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("Esteban", "4670296","27", "097308977", "Casa Central");
            Doctor doctor1 = new Doctor ("Dr.Programacion","C#");
            string appointmentResult = AppointmentService.CreateAppointment(patient1, DateTime.Now, doctor1);
            Console.WriteLine(appointmentResult);
            Patient patient2= new Patient("Valentina", "49856584","27", "09999999", "Policlinica");
            Doctor doctor2 = new Doctor ("Dr.Hola","Adios");
            string appointmentResult2 = AppointmentService.CreateAppointment(patient2, DateTime.Now, doctor2);
            Console.WriteLine(appointmentResult2);

            //string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            //Console.WriteLine(appointmentResult2);
        }
    }
}
