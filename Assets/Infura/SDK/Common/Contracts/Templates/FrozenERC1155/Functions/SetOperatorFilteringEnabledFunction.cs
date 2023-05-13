using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.Contracts;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Truffle.Data;

namespace Truffle.Functions
{
    public partial class SetOperatorFilteringEnabledFunction : SetOperatorFilteringEnabledFunctionBase { }

    [Function("setOperatorFilteringEnabled")]
    public class SetOperatorFilteringEnabledFunctionBase : FunctionMessage
    {
        [Parameter("bool", "value", 1)]
        public virtual bool Value { get; set; }
    }
}
