using System;
namespace DapperExercise
{
	public interface IDepartmentRepository
	{
		IEnumerable<Department> GetAllDepartments();
	}
}

