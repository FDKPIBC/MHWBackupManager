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

        public string SteamId { get; set; } = string.Empty;

        public string Root { get; set; }

        public long Size { get; set; }

        public DateTime LocalTime { get; set; }

        public DateTime Time { get; set; }

        public DateTime RemoteTime { get; set; }

        public string SHA1 { get; set; }

        public int SyncState { get; set; }

        public int PersistState { get; set; }

        public int PlatformsToSync2 { get; set; }
    }
}
