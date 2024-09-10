using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_MVC_.Models
{
    public class Library
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Thana { get; set; }

    }


}
