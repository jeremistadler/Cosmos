﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cosmos.Compiler.Assembler;
using Cosmos.Compiler.Assembler.X86;

namespace Cosmos.Compiler.XSharp {
  public class AddressIndirect : Address {
    public readonly RegistersEnum? Register;
    public readonly ElementReference Reference;
    public readonly uint Address;
    public readonly int Displacement;

    public AddressIndirect(string aLabel, Int32 aDisplacement) {
      Reference = ElementReference.New(aLabel);
      Displacement = aDisplacement;
    }
    public AddressIndirect(Register32 aBaseRegister, Int32 aDisplacement) {
      Register = Registers.GetRegister(aBaseRegister.Name);
      Displacement = aDisplacement;
    }
    public AddressIndirect(uint aBaseAddress, int aDisplacement) {
      Address = aBaseAddress;
      Displacement = aDisplacement;
    }

    public string GetDest() {
      // This is not currently used
      string xResult;
      if (Register != null) {
        xResult = Registers.GetRegisterName(Register.Value);
      //} else if (Label != null) {
      //  xResult = Label;
      } else {
        xResult = Address.ToString();
      }
      return xResult;
    }

    public override string ToString() {
      return "[" + GetDest() + (Displacement == 0 ? "" : " + " + Displacement) + "]";
    }
  }
}
