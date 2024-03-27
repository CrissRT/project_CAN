using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using project_CAN.Domain.Entities.User;

namespace project_CAN.BusinessLogic.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() :
            base("name=project_CAN_DB") // connectionstring name define in your web.config
        {
        }

        public virtual DbSet<UDbTable> Users { get; set; }
    }
}