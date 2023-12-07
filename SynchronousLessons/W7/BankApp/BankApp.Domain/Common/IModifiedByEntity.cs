namespace BankApp.Domain.Common
{
    public interface IModifiedByEntity
    {
        DateTime? ModifiedOn { get; set; }
        string? ModifiedByUserId { get; set; }
    }
}