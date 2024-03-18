using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aria2Net
{
    public interface IAria2Client
    {
        Uri Uri { get; }
        string Secret { get; }
        string Id { get; }
    }
}
