using BackOffice.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackOffice.Repository
{
    public class HomeIndexRepository:IHomeIndexRepository
    {
        public List<Dictionary<string, object>> appVersion()
        {

            List<Dictionary<string, object>> listVersion = new List<Dictionary<string, object>>();
            Dictionary<string, object> dicVersion1 = new Dictionary<string, object>();
            dicVersion1.Add("version", "0.1.5.2");
            dicVersion1.Add("usage", "123k");
            listVersion.Add(dicVersion1);
            Dictionary<string, object> dicVersion2 = new Dictionary<string, object>();
            dicVersion2.Add("version", "0.1.5.3");
            dicVersion2.Add("usage", "53k");
            listVersion.Add(dicVersion2);
            Dictionary<string, object> dicVersion3 = new Dictionary<string, object>();
            dicVersion3.Add("version", "0.1.5.4");
            dicVersion3.Add("usage", "23k");
            listVersion.Add(dicVersion3);
            Dictionary<string, object> dicVersion4 = new Dictionary<string, object>();
            dicVersion4.Add("version", "0.1.5.5");
            dicVersion4.Add("usage", "3k");
            listVersion.Add(dicVersion4);
            Dictionary<string, object> dicVersion5 = new Dictionary<string, object>();
            dicVersion5.Add("version", "0.1.5.6");
            dicVersion5.Add("usage", "1k");
            listVersion.Add(dicVersion5);

            return listVersion;
        }
    }
}