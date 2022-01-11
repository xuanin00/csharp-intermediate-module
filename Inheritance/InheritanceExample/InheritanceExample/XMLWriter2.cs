using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class XMLWriter2: XMLWriter
    {
        public XMLWriter2(string fileName)
            :base(fileName)
        {
        }
        public new void SetName()
        {
            base.SetName();
            Console.WriteLine("Setting name in the XMLWriter2 class");
        }
        public override void CalculateFileSize()
        {
            base.CalculateFileSize();
            Console.WriteLine("Calculating file size in the XMLWriter2 class");
        }

    }
}
