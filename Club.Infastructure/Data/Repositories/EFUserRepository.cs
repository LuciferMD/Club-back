using Club.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Club.Infastructure.Data.Repositories
{
    public class EFUserRepository
    {
        private ClubDBContext context;

        public EFUserRepository(ClubDBContext context)
        {
            this.context = context;
        }

        public User Get(Guid id)
        {
            return context.Users.Find(id);
        }
    }
}
