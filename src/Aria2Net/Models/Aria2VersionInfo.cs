using System;
using System.Collections.Generic;
using System.Text;

namespace Aria2Net
{
    public class Aria2VersionInfo
    {
        /// <summary>
        /// Version number of aria2 as a string.
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// enabledFeatures
        /// </summary>
        public ICollection<string> EnabledFeatures { get; set; }
    }
}
