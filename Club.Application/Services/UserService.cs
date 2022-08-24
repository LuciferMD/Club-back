using Club.Domain.Entities;
using Club.Infastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Club.Application.Services
{
    public class UserService
    {
        private EFUserRepository userRepository;

        public UserService(EFUserRepository userRepository)
        {
            this.userRepository = userRepository;              
        }

        public User Get(Guid id)
        {
            return userRepository.Get(id);
        }
    }
}
