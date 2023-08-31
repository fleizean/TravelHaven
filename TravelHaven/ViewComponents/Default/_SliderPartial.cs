using System;
using Microsoft.AspNetCore.Mvc;

namespace TravelHaven.ViewComponents.Default
{
	public class _SliderPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

