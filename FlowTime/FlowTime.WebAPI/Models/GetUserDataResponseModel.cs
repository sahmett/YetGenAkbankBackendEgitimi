using FlowTime.Domain.Enum;
using FlowTime.WebAPI.Models.ModelMetaDataTypes;
using Microsoft.AspNetCore.Mvc;

namespace FlowTime.WebAPI.Models
{

    public class GetUserDataResponseModel
    {
            public Guid Id { get; set; }
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
