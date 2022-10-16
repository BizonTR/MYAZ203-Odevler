using ClassLibrary1;
using ConsoleApp1;

EmployeeManager employeeManager = new EmployeeManager();


Employee newemp1 = new Employee() { Id = 5 };




employeeManager.AddEmp(newemp1);
employeeManager.RemoveEmp(5);
employeeManager.RemoveEmp(7);
employeeManager.GetAll();