using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVO.Parameters
{
    public class NullCoordinate : Coordinate
    {
        public override bool IsNull()
        {
            return true;
        }
    }
}
