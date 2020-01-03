// Autogenerated from KST: please remove this line if doing any edits by hand!

using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecDefaultEndianMod : CommonSpec
    {
        [Test]
        public void TestDefaultEndianMod()
        {
            var r = DefaultEndianMod.FromFile(SourceFile("fixed_struct.bin"));

            Assert.AreEqual(r.Main.One, 1262698832);
            Assert.AreEqual(r.Main.Nest.Two, -52947);
            Assert.AreEqual(r.Main.NestBe.Two, 1346454347);
        }
    }
}