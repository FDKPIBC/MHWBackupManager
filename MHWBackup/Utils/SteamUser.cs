using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWBackup
{
    public class SteamUser
    {
        public string SteamId { get; set; }

        public string UserName { get; set; }

        public string UserBaseDir { get; set; }

        public Dictionary<string, string> GameDir { get; set; }
    }
}
