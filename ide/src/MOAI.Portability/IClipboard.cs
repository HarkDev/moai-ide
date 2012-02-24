﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOAI.Portability
{
    public interface IClipboard
    {
        ClipboardContentType Type { get; }
        object Contents { get; }

        void Set(ClipboardContentType type, object contents);
    }
}
