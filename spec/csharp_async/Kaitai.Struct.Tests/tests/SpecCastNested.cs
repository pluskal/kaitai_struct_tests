// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecCastNested : CommonSpec
    {
        [Test]
        public async Task TestCastNested()
        {
            var r = CastNested.FromFile(SourceFile("switch_opcodes.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.Opcodes0Str.Value, "foobar");
            Assert.AreEqual(r.Opcodes0StrValue, "foobar");
            Assert.AreEqual(r.Opcodes1Int.Value, 66);
            Assert.AreEqual(r.Opcodes1IntValue, 66);
        }
    }
}