﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Converter
{
    public interface IParce<O,D>
    {
        D Parce(O origin);
        List<D> ParceList(List<O> origin);
    }
}
