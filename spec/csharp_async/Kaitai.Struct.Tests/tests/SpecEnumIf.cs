// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecEnumIf : CommonSpec
    {
        [Test]
        public async Task TestEnumIf()
        {
            var r = EnumIf.FromFile(SourceFile("if_struct.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.Op1.Opcode, EnumIf.Opcodes.AString);
            Assert.AreEqual(r.Op1.ArgStr.Str, "foo");
            Assert.AreEqual(r.Op2.Opcode, EnumIf.Opcodes.ATuple);
            Assert.AreEqual(r.Op2.ArgTuple.Num1, 66);
            Assert.AreEqual(r.Op2.ArgTuple.Num2, 67);
            Assert.AreEqual(r.Op3.Opcode, EnumIf.Opcodes.AString);
            Assert.AreEqual(r.Op3.ArgStr.Str, "bar");
        }
    }
}