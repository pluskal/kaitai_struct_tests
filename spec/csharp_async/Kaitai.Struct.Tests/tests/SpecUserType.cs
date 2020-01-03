// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecUserType : CommonSpec
    {
        [Test]
        public async Task TestUserType()
        {
            var r = UserType.FromFile(SourceFile("repeat_until_s4.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.One.Width, 66);
            Assert.AreEqual(r.One.Height, 4919);
        }
    }
}