using System;
using System.Data;
using Dapper;

namespace DapperExercise
{
	public class DapperDepartmentRepository : IDepartmentRepository
	{
		private readonly IDbConnection _connection;

		public DapperDepartmentRepository(IDbConnection connection)
		{
			_connection = connection;
		}

        public IEnumerable<Department> GetAllDepartments()
		{
			return _connection.Query<Department>("SELECT * FROM departments;");
		}
        
    }
}

