using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementUser.Api.DataAccess.Contract.Entities
{
    public class UserEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
