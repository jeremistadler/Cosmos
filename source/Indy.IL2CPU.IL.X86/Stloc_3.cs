using System;
using System.IO;
using Mono.Cecil.Cil;
using CPU = Indy.IL2CPU.Assembler.X86;

namespace Indy.IL2CPU.IL.X86 {
	[OpCode(Code.Stloc_3)]
	public class Stloc_3: Op {
		public override void Assemble(Instruction aInstruction) {
			throw new NotImplementedException("This file has been autogenerated and not been changed afterwards!");
		}
	}
}