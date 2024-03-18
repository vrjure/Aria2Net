using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aria2Net
{
    public class Aria2MulticallMethod
    {
        public Aria2MulticallMethod() { }

        public Aria2MulticallMethod(Aria2Request request)
        {
            MethodName = request.Method;
            Params = request.Params.ToList();
        }

        public string MethodName { get; set; }
        public ICollection<object> Params { get; set; }
    }
}
