﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColinsBakeryShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        IEnumerable<Pie> PiesOfTheWeek { get; }

        Pie GetPieById(int pieId);
    }
}
