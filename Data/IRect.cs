using System;
using System.Collections.Generic;
using System.Text;

namespace CarModelSdk_NetCore
{
    interface IRect
    {
        int X { get; set; }
        int Y { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }
}
