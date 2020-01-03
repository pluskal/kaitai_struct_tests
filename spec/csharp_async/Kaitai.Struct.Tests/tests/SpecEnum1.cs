// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecEnum1 : CommonSpec
    {
        [Test]
        public async Task TestEnum1()
        {
            var r = Enum1.FromFile(SourceFile("enum_0.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.Main.Submain.Pet1, Enum1.MainObj.Animal.Cat);
            Assert.AreEqual(r.Main.Submain.Pet2, Enum1.MainObj.Animal.Chicken);
        }
    }
}