using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPro.Models
{
    public class EFAplicationRepository : IPhoneCallerRepository
    {
        private ApplicationDbContext context;
        public EFAplicationRepository(ApplicationDbContext context) => this.context = context;
        public IQueryable<PhoneCaller> PhoneCallers => context.PhoneCallers;

        public void AddPhoneCaller(PhoneCaller phoneCaller)
        {
            throw new NotImplementedException();
        }

        public void DeletePhoneCaller(int id)
        {
            throw new NotImplementedException();
        }
    }
}
