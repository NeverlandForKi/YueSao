using BBT.DAL.Models;
using System;

namespace BBT.BLL.User
{
    public class UserBLL
    {
        public void GetYueSaoList()
        {
            var db = new PetaPoco.Database("BBTDataBaseConnection");
            var hotelList = db.Query<dat_sclient_base>("select * from dat_sclient_base");
            foreach (var item in hotelList)
            {
                Console.Write(item.c_addr);
            }
        }
    }
}
