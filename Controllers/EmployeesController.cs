using System;
using crud.Database;
using crud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace crud.Controllers {

	public class EmployeesController : Controller {
		private readonly ApplicationDBContext database;
		public EmployeesController(ApplicationDBContext database) {
			this.database = database;
		}
		public IActionResult Index() {
			var employees = database.Employees.ToList();
			return View(employees);
		}
		public IActionResult Register() {
			return View();
		}

		[HttpPost]
		public IActionResult Save(Employee employee) {
			if (employee.Id == 0) {
				// Save employee
				database.Employees.Add(employee);
			} else {
				// Update employee
				Employee registeredEmployee = database.Employees.First(record => record.Id == employee.Id);
				registeredEmployee.Name = employee.Name;
				registeredEmployee.Cpf = employee.Cpf;
				registeredEmployee.Salary = employee.Salary;
			}
			database.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Edit(int id) {
			Employee employee = database.Employees.First(record => record.Id == id);
			return View("Register", employee);
		}

		public IActionResult Delete(int id) {
			Employee employee = database.Employees.First(record => record.Id == id);
			database.Employees.Remove(employee);
			database.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}