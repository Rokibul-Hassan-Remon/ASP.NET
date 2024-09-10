
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement_MVC_.Models
{
    public class Hospital
    {
        [Key]
        public int  ID { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Problem { get; set; }

    }

}
