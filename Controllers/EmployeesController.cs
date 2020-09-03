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
			database.Employees.Add(employee);
			database.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}