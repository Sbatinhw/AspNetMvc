using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeScanner
{
    internal interface IScanner
    {
        public byte[] GetScan();
    }
}
