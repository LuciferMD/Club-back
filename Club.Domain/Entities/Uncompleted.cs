using System;
using System.Collections.Generic;
using System.Text;

namespace Club.Domain.Entities
{
    public class Uncompleted
    {
        public Guid Id { get; set; }
        public Guid User_id { get; set; }
        public Guid Enter_id { get; set; }

        //Relationships

        public List<User> Users { get; set; }
        public List<Entertainment> Entertainments { get; set; }
    }

}
