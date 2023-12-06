// CreateUserRequestModel.cs
using FluentValidation;
using FlowTime.Domain.Enum;

namespace FlowTime.WebAPI.Models
{
    public class CreateUserRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int WorkTime { get; set; }
        public bool IsGraduated { get; set; }
        public Int16 Age { get; set; }
        public Gender Gender { get; set; }
    }

   
}
