using BankApp.Domain.Common;

namespace BankApp.Domain.Entities
{
    public class Person : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public BankAccount? Account { get; set; }
    }
}