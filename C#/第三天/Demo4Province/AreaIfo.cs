﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Province
{
    public class AreaIfo
    {
        public string AreaName { get; set; }
        public int AreaPid { get; set; }
        public int AreaId { get; set;}
        public override string ToString()
        {
            return AreaName.ToString();
        }

    }
}
