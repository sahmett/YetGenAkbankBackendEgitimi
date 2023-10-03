using OOP_TextProject.Enums;
using OOP_TextProject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TextProject.Entities
{
    public class AccessControlLog : EntitiyBase<Guid>
    {

        
        public long PersonId { get; set; }
        public string DeviceSerialNo { get; set; }
        public AccessType AccesType { get; set; }
        public DateTime LogTime { get; set; }

        public static  AccessType ConvertStringToAccesType(string accesType)
        {
           switch (accesType)
            {
                case "FP":
                    return AccessType.FP;
                case "FACE":
                    return AccessType.FACE;
                case "CARD":
                    return AccessType.Card;
                default:
                    throw new Exception("acces type error");
            }
           /*
            * return ediyorsak kod aşağı doğru devam etmez. Bu yüzden break kullanmaya gerek yok. 
            */
        }
    }
}
