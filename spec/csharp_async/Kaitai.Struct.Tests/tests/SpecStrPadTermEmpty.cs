// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecStrPadTermEmpty : CommonSpec
    {
        [Test]
        public async Task TestStrPadTermEmpty()
        {
            var r = StrPadTermEmpty.FromFile(SourceFile("str_pad_term_empty.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.StrPad, "");
            Assert.AreEqual(r.StrTerm, "");
            Assert.AreEqual(r.StrTermAndPad, "");
            Assert.AreEqual(r.StrTermInclude, "@");
        }
    }
}