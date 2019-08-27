using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Common.Interfaces
{
    public interface IData
    {
        Dictionary<string, string> GetTypesOfPages();
    }
}
