using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasjidManagement.Models
{
	public class Imam
	{
		[Key] public int Id { get; set; }
		public int ImamId { get; set; }
		public String ImamName { get; set; }
		public String Qualification { get; set; }
		public String HireDate {  get; set; }

        public string ImamJoinDate { get; set; }

        public string OnDuty { get; set; }

        public string ImamGender { get; set; }

        public string ImamCountry { get; set; }

        public string ImamBirth { get; set; }

        public string ImamBirthTime { get; set; }

        public int ImamAge { get; set; }

        public string ImamFavColor { get; set; }

        public string File_Name { get; set; }

        [NotMapped]
        public string Uploaded_File { get; set; }
    }
}
