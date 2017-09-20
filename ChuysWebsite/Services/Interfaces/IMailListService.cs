using ChuysWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuysWebsite.Services.Interfaces
{
    public interface IMailListService
    {
        int Insert(MailListAddRequest model);
    }
}
