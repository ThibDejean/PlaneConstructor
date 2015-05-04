using NUnit.Framework;
using PlaneConstructor.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneConstructor.Tests
{
    [TestFixture]
    public class SubsetTest
    {
        [Test]
        public void Subset_infos_are_well_calculated()
        {
            ConvertExcel test = new ConvertExcel();
            Subset poigneegaz = new Subset();

            string excelPath = @"D:\Dev\S5\Projet C#\Excel pour PlaneConstructor\poigneegaz.xlsx";
            string CSVPath = excelPath;
            CSVPath = CSVPath.Remove(CSVPath.Length - 4, 4) + "csv";
            test.ConvertExcelToCsv(excelPath, CSVPath, 1);
            poigneegaz = test.GetDataTableFromCsv(CSVPath);

            int result1 = poigneegaz.GetTheLongestDOSub();
            // TODO pb de double

            double result2 = poigneegaz.GetTotalCostSub();
            int result3 = poigneegaz.GetTotalHourSub();
            int result4 = poigneegaz.GetMaxLevel();
            Assert.That(result1, Is.EqualTo(752));
            Assert.That(result2, Is.EqualTo(60598.25d));
            Assert.That(result3, Is.EqualTo(406));
            Assert.That(result4, Is.EqualTo(7));            
        }

       

    }
}
