using System;
using crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers {
	public class EmployeesController : Controller {
		public IActionResult Register() {
			return View();
		}

		[HttpPost]
		public IActionResult Save(Employee employee) {
			return Content("Saved");
		}
	}
}