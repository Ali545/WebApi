using System;
namespace Coursework.Models
{
	public class Appointment
	{
        public int AppointmentId { get; set; }

        public int patientId { get; set; }

        public int doctorId { get; set; }
        
        public DateTime AppointmentDateTime { get; set; }
    }
}

