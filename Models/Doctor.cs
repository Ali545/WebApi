using System.Text.Json.Serialization;
namespace Coursework.Models
{
	public class Doctor
	{
		public int doctorId { get; set; }

		public string? doctorName { get; set; }

		[JsonIgnore]
		public int departmentId { get; set; }

		[JsonIgnore]
		public Department? department { get; set; }
	}
}

