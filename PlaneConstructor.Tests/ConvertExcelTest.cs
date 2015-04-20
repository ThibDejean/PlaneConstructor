using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneConstructor.Tests
{
    [TestFixture]
    public class ConvertExcelTest
    {
        [Test]
        public void ConvertExcelToCSV_with_no_file()
        {
            ConvertExcel test = new ConvertExcel();
            Assert.Throws<ArgumentException>(() => test.ConvertExcelToCsv("   ", "   ", 5));
            Assert.Throws<ArgumentException>(() => test.ConvertExcelToCsv(string.Empty, string.Empty, 2));
            Assert.Throws<FileNotFoundException>(() => test.ConvertExcelToCsv("argeuh.xlp", "not null", 2));
        }
    }
}
