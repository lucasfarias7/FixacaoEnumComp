using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoEnumComp.Entities.Enum
{
    public enum StatusPedido : int
    {
        Pending_Payment,
        Processing,
        Shipped,
        Delivered
    }
}
