using System;
using System.Collections.Generic;
using System.Text;

namespace Aria2Net
{
    public enum Aria2DownloadStatus
    {
        active = 0,
        waiting,
        download,
        paused,
        error,
        complete,
        removed
    }
}
