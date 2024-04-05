using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public enum RoomStyle
    {
        [Description("Twin Room")]
        TwinRoom,
        [Description("Queen Room")]
        QueenRoom,
        [Description("King Room")]
        KingRoom,
    }
}
