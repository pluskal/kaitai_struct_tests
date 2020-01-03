// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecIntegers : CommonSpec
    {
        [Test]
        public async Task TestIntegers()
        {
            var r = Integers.FromFile(SourceFile("fixed_struct.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.Uint8, 255);
            Assert.AreEqual(r.Uint16, 65535);
            Assert.AreEqual(r.Uint32, 4294967295);
            Assert.AreEqual(r.Uint64, 18446744073709551615);
            Assert.AreEqual(r.Sint8, -1);
            Assert.AreEqual(r.Sint16, -1);
            Assert.AreEqual(r.Sint32, -1);
            Assert.AreEqual(r.Sint64, -1);
            Assert.AreEqual(r.Uint16le, 66);
            Assert.AreEqual(r.Uint32le, 66);
            Assert.AreEqual(r.Uint64le, 66);
            Assert.AreEqual(r.Sint16le, -66);
            Assert.AreEqual(r.Sint32le, -66);
            Assert.AreEqual(r.Sint64le, -66);
            Assert.AreEqual(r.Uint16be, 66);
            Assert.AreEqual(r.Uint32be, 66);
            Assert.AreEqual(r.Uint64be, 66);
            Assert.AreEqual(r.Sint16be, -66);
            Assert.AreEqual(r.Sint32be, -66);
            Assert.AreEqual(r.Sint64be, -66);
        }
    }
}