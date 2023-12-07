namespace BankApp.Domain.Common
{
    public interface IDeletedByEntity
    {
        DateTime? DeletedOn { get; set; }
        string? DeletedByEntity { get; set; }
        bool? IsDeleted { get; set; }
    }
}