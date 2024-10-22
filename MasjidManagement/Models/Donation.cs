using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasjidManagement.Models
{
    public class Donation
    {
        [Key]
        public int Id { get; set; }

        public String DonorId { get; set; }     //

        public String DonorName { get; set; }   //

        public int Amount { get; set; }         

        public DateTime DonationDate { get; set; }

        public string IsSubscribe { get; set; }

        public string DonorGender { get; set; }

        public string DonorCountry{ get; set; }

        public DateTime DonorBirth { get; set; }        //

        public int DonorAge { get; set; }

        public string? FileName {  get; set; }
        [NotMapped]
        public IFormFile Uploaded_File { get; set; }

        public string DonorFavColor {  get; set; }

    }
}
