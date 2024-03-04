using System;
namespace Coursework.Models
{
	public class Appointment
	{
        public int AppointmentId { get; set; }

        public Patient? Patient { get; set; }

        public Doctor? Doctor { get; set; }
        
        public DateTime AppointmentDateTime { get; set; }
    }
}

