using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColinsBakeryShop.Models
{
    public class ICategoryRepository
    {
        public IEnumerable<Category> Categories { get; }
    }
}
