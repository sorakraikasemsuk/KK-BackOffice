using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.IRepository
{
    public interface IHomeIndexRepository
    {
       List<Dictionary<string, object>> appVersion();
    }
}
