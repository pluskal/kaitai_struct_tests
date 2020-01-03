// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecProcessXorConst : CommonSpec
    {
        [Test]
        public async Task TestProcessXorConst()
        {
            var r = ProcessXorConst.FromFile(SourceFile("process_xor_1.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.Key, 255);
            Assert.AreEqual(r.Buf, new byte[] { 102, 111, 111, 32, 98, 97, 114 });
        }
    }
}