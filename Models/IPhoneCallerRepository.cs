using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPro.Models
{
    public interface IPhoneCallerRepository
    {
        IQueryable<PhoneCaller> PhoneCallers { get; }
        void AddPhoneCaller(PhoneCaller phoneCaller);
        void DeletePhoneCaller(int id);
    }
}
