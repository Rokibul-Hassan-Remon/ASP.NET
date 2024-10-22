using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasjidManagement.Models
{
	public class Volunteer
	{
		[Key] public int Id { get; set; }
		public String VId { get; set; }
		public String VName { get; set; }
		public String VRole { get; set; }
		public String VContactNumber {  get; set; }

        public string Active { get; set; }

        public string VolunteerGender { get; set; }

        public string VolunteerCountry { get; set; }

        public string VolunteerBirth { get; set; }

        public string VolunteerBirthTime { get; set; }

        public int VolunteerAge { get; set; }

        public string VolunteerFavColor { get; set; }

        public string File_Name {  get; set; }

        [NotMapped]
        public IFormFile Uploaded_File { get; set; }

    }
}
