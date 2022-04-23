using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeScanner
{
    internal class Scanner : IScanner
    {
        private readonly IDataSource dataSource;
        public Scanner(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public byte[] GetScan()
        {
            return dataSource.GetData();
        }
    }
}
