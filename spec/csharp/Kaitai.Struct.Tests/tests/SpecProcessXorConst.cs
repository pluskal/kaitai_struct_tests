// Autogenerated from KST: please remove this line if doing any edits by hand!

using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecProcessXorConst : CommonSpec
    {
        [Test]
        public void TestProcessXorConst()
        {
            var r = ProcessXorConst.FromFile(SourceFile("process_xor_1.bin"));

            Assert.AreEqual(r.Key, 255);
            Assert.AreEqual(r.Buf, new byte[] { 102, 111, 111, 32, 98, 97, 114 });
        }
    }
}