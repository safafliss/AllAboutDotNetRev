﻿using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServicePrestation:IService<Prestation>
    {
        public double GetPrixMoy();
    }
}
