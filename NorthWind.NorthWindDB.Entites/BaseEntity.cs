﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.Entites
{
    public abstract class BaseEntity
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
