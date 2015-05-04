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
    public class LineTest
    {
        [Test]
        public void TryToParse_with_a_string_work()
        {
            Line l = new Line();
            int result = l.TryToParse("5");
            Assert.That(result, Is.EqualTo(5));
        }

        public void TryToParse_with_not_a_int()
        {
            Line l = new Line();
            
            Assert.Throws<FormatException>( () => l.TryToParse(null));
            Assert.Throws<FormatException>(() => l.TryToParse("abc"));
            Assert.Throws<FormatException>(() => l.TryToParse(" "));
            Assert.Throws<FormatException>(() => l.TryToParse("5.58"));
            Assert.Throws<FormatException>(() => l.TryToParse("5,58"));

        }

    }
}
