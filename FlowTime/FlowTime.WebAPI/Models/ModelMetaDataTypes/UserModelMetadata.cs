using System.ComponentModel.DataAnnotations;

namespace FlowTime.WebAPI.Models.ModelMetaDataTypes
{
    public class UserModelMetadata
    {
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "WorkTime is required.")]
        public int WorkTime { get; set; }

    }
}
