using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TextProject.Common
{
    public class EntitiyBase 
    {
        public Guid id {  get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
/**
 * Entity Base'i veritabanına göndereceğimiz her şeyde kullanırız.
 * Mesela hepsinde Guid kullanmak istemiyorsam verdiğim veri tipine göre değiştirebilirim.
 * class EntityBase<T> şeklinde yazdığımızda T'ye verdiğimiz veri tipine göre değişir.
 */