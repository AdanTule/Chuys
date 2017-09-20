using ChuysWebsite.Models;
using ChuysWebsite.Services.Interfaces;
using DbConnector.Adapter;
using DbConnector.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ChuysWebsite.Services
{
    public class MailListService: IMailListService
    {
        IBaseService _baseService;

        public MailListService(IBaseService baseService)
        {
            _baseService = baseService;

        }
        public int Insert(MailListAddRequest model)
        {
            SqlParameter Id = SqlDbParameter.Instance.BuildParam("@Id", 0, System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Output);

            _baseService.SqlAdapter.ExecuteDbScalar(new DbCommandDef
            {
                DbCommandText = "[dbo].[SiteUser_Insert]",
                DbCommandType = System.Data.CommandType.StoredProcedure,
                DbParameters = new System.Data.IDbDataParameter[] {
                    new SqlParameter("@FirstName", model.FirstName),
                    new SqlParameter("@LastName", model.LastName),
                    new SqlParameter("@Unsubscribe", model.Unsubscribe),
                    new SqlParameter("@Email", model.Email),
                    Id
                }
            });
            return Id.Value.ToInt32();

        }
    }
}