
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasjidManagement.Models
{
    public class Event
    {
		[Key]
        public int Id { get; set; }

		public String EventName { get; set; }
        public string EventId { get; set; }
        public string Location { get; set; }
        public string File_Name { get; set; }
        [NotMapped]
        public IFormFile Uploaded_File { get; set; }
    }
}
