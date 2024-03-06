using System.Text.Json.Serialization;
namespace Coursework.Models
{
	public class Doctor
	{
		public int doctorId { get; set; }

		public string? doctorName { get; set; }

		public int departmentId { get; set; }
	}
}