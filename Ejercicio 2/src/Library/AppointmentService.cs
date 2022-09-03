using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        private static int count = 0;
        public int Count { get; private set; }
        public static string CreateAppointment(Patient patient, DateTime date, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(patient.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.Id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.Edad))
            {
                stringBuilder.Append("Unable to schedule appointment, 'edad' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.AppointmentService))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctor.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctor.Specialty))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                count++;
                stringBuilder.Append("Appoinment scheduled \nNumber: " + count);
                //
            }

            return stringBuilder.ToString();
        }

    }
}

/* En primer lugar cree 2 clases nuevas, una para los datos del paciente y otra para el doctor. 
De esta forma logro ordenar mejor el programa y en casos de modificaciones el mantinimiento será mucho
más amigable. Estas 2 clases tiene como responsabilidad adquirir la información de los mismos.
Por otro lado la clase AppointmentService la modifique para poder ingresar objetos del tipo
"Patient" y "Doctor". Tambien agregue un contador, el cual generá el identificador que se solicita en
la parte numero 3. Esta clase tiene como responsabilidad validar los datos que son ingresados.*/