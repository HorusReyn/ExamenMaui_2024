using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindExamenMaui.Data.IRepository
{
    public interface ISoortRepository
    {
        public ICollection<Soort> OphalenSoorten();
    }
}
