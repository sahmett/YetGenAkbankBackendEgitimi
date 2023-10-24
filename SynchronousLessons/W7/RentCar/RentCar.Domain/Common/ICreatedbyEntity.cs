namespace RentCar.Domain.Common
{
    public interface ICreatedbyEntity
    {
        public DateTime CreatedOn { get; set; }
        public string CreatedByUserId { get; set; }


    }
}