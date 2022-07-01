using Application.Discounts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    public class DiscountsController : Controller
    {
        private readonly IGetDescountesForAdmin getDescountes;

        public DiscountsController(IGetDescountesForAdmin getDescountes)
        {
            this.getDescountes = getDescountes;
        }
        public IActionResult Index(int page=1, int pageSize=10)
        {
            var model = getDescountes.GetListDescounts(page, pageSize);
            return View(model);
        }
    }
}
