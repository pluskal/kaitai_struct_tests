// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecPositionToEnd : CommonSpec
    {
        [Test]
        public async Task TestPositionToEnd()
        {
            var r = PositionToEnd.FromFile(SourceFile("position_to_end.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.Index.Foo, 66);
            Assert.AreEqual(r.Index.Bar, 4660);
        }
    }
}