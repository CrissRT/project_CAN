using project_CAN.BusinessLogic.Interfaces;
using project_CAN.BusinessLogic;

namespace project_CAN.BusinessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}
