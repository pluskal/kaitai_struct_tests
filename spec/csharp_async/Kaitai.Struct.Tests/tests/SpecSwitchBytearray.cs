// Autogenerated from KST: please remove this line if doing any edits by hand!

using System.Threading.Tasks;
using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecSwitchBytearray : CommonSpec
    {
        [Test]
        public async Task TestSwitchBytearray()
        {
            var r = SwitchBytearray.FromFile(SourceFile("switch_opcodes.bin"));
            await r.ReadAsync();

            Assert.AreEqual(r.Opcodes.Count, 4);
            Assert.AreEqual(r.Opcodes[0].Code, new byte[] { 83 });
            Assert.AreEqual(((SwitchBytearray.Opcode.Strval) (r.Opcodes[0].Body)).Value, "foobar");
            Assert.AreEqual(r.Opcodes[1].Code, new byte[] { 73 });
            Assert.AreEqual(((SwitchBytearray.Opcode.Intval) (r.Opcodes[1].Body)).Value, 66);
            Assert.AreEqual(r.Opcodes[2].Code, new byte[] { 73 });
            Assert.AreEqual(((SwitchBytearray.Opcode.Intval) (r.Opcodes[2].Body)).Value, 55);
            Assert.AreEqual(r.Opcodes[3].Code, new byte[] { 83 });
            Assert.AreEqual(((SwitchBytearray.Opcode.Strval) (r.Opcodes[3].Body)).Value, "");
        }
    }
}