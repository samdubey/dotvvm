﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotVVM.Framework.Compilation.ControlTree
{
    public interface IAbstractHtmlAttributeValue : IAbstractHtmlAttributeSetter
    {
        string Value { get; }
    }
}
