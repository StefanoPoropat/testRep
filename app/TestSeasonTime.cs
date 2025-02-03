using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace testRep
{
    internal class Test
    {
        public string _startOfTests, _endOfTests;
        private string startOfTests {get => _startOfTests; set => _startOfTests = value; }
        private string endOfTests { get => _endOfTests; set => _endOfTests = value; }

        public Test(string start, string end)
        {
            _startOfTests = start;
            _endOfTests = end;
        }

        public override string ToString()
        {
            return $"{startOfTests}";
        }
        public string ToString2()
        {
            return $"{endOfTests}";
        }
    }
}
