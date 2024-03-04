using System;
using System.Text.Json.Serialization;
namespace Coursework.Models
{
	public class Bill
	{
		public int billId { get; set; }

		public int? billAmount { get; set; }

		public DateTime? billDate { get; set; }

		[JsonIgnore]
		public int? PatientId { get; set; }
    }
}

