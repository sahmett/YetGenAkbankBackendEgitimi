namespace RentCar.Domain.Common
{
    public interface IDeletedByEntity
    {
        DateTime? CreatedOn { get; set; }
        String? CreatedByUserId { get; set; }
        public bool? IsDeleted { get; set; }

    }
}