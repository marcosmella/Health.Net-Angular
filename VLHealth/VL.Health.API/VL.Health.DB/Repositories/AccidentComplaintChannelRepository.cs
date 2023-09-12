using Dapper;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Data.SqlClient;
using VL.Health.Domain.Entities;
using VL.Health.Domain.Enums;
using VL.Health.Interfaces.Repositories;
using VL.Libraries.Common.Helpers.Header;
using VL.Libraries.TenantDataAccess.Resolver;

namespace VL.Health.DB.Repositories
{
	public class AccidentComplaintChannelRepository : IAccidentComplaintChannelRepository
	{
		private readonly string _connectionString;

		public AccidentComplaintChannelRepository(ITenantResolver tenantResolver, IHttpContextAccessor httpContextAccessor)
		{
			_connectionString = tenantResolver.GetTenantConnection(new HeaderHelper(httpContextAccessor).GetTenant());
		}
		public List<AccidentComplaintChannel> Get()
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				var sql = @$"SELECT
					soaccidente_valores_control.idvalor as Id,
					soaccidente_valores_control.valor as Description
					FROM 
						soaccidente_valores_control
					where soaccidente_valores_control.idcontrol = {(int)AccidentValueControl.ComplaintChannel}";

				return connection.Query<AccidentComplaintChannel>(sql).AsList();
			}
		}
	}
}
