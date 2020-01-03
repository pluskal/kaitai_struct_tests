// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecHelloWorld : CommonSpec
    {
        [Test]
        public async Task TestHelloWorld()
        {
            var r = HelloWorld.FromFile(SourceFile("fixed_struct.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.One, 80);
        }
    }
}