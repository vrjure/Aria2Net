﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aria2Net
{
    public class Aria2ServerInfo
    {
        /// <summary>
        /// Original URI.
        /// </summary>
        public string Uri { get; set; }
        /// <summary>
        /// This is the URI currently used for downloading. 
        /// If redirection is involved, currentUri and uri may differ.
        /// </summary>
        public string CurrentUri { get; set; }
        /// <summary>
        /// Download speed (byte/sec)
        /// </summary>
        public int DownloadSpeed { get; set; }
    }
}
