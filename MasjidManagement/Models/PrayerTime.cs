using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasjidManagement.Models
{
	public class PrayerTime
	{
		[Key] public int Id { get; set; }
		public String PrayerName {  get; set; }
		public String PrayerStart { get;set; }
		public String PrayerEnd { get; set; }

		public string File_Name {  get; set; }
		[NotMapped]
		public IFormFile Uploaded_File { get; set; }



	}
}
