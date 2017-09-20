using DbConnector.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuysWebsite.Services.Interfaces
{
    public interface IBaseService
    {
        IDbAdapter SqlAdapter { get; }
    }
}
