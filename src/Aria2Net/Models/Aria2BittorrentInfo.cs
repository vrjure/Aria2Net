using System;
using System.Collections.Generic;
using System.Text;

namespace Aria2Net
{
    public class Aria2BittorrentInfo
    {
        /// <summary>
        /// name in info dictionary. name.utf-8 is used if available.
        /// </summary>
        public string Name { get; set; }
    }
}
