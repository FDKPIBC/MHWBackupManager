using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWBackup
{
    public class Backup
    {
        public string SteamName { get; set; }

        public string Path { get; set; }

        public DateTime CreateTime { get; set; }

        public string FileHash { get; set; }

        public string SteamId { get; set; } = string.Empty;
    }
}
