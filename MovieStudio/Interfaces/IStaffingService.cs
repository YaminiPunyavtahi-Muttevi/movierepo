using MovieStudio.Thirdparty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Interfaces
{
    public interface IStaffingService
    {
        List<StudioEmployee> GetStaff();

    }
}
