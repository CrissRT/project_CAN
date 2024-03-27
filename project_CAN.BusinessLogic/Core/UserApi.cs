using System.Linq;
using project_CAN.BusinessLogic.DBModel;
using project_CAN.Domain.Entities.User;

namespace project_CAN.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            UDbTable user;

            using (var db = new UserContext())
            {
                user = db.Users.FirstOrDefault(u => u.Username == data.Username);
            }

            using (var db = new UserContext())
            {
                user = (from u in db.Users where u.Username == data.Username select u).FirstOrDefault();
            }


            if (user != null)
            {

            }

            return new ULoginResp();
        }
    }
}
