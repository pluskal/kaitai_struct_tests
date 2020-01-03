

// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecEnum0 : CommonSpec
    {
        [Test]
        public async Task TestEnum0()
        {
            var r = Enum0.FromFile(SourceFile("enum_0.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.Pet1, Enum0.Animal.Cat);
            Assert.AreEqual(r.Pet2, Enum0.Animal.Chicken);
        }
    }
}