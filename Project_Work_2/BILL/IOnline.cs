using Project_Work_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Work_2.BILL
{
    public interface IOnlineRepo
    {
        List<OnlineJobSite> GetAll();
        List<OnlineJobSite> GetWithChildred();
        OnlineJobSite Get(int id);
        bool Insert(OnlineJobSite oj);
        bool Update(OnlineJobSite oj, bool childIncluded = false);
        bool Delete(int id);
    }
}
