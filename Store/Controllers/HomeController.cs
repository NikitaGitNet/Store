using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Store.BLL.DTO;
using Store.BLL.Interfaces;
using Store.WEB.Models;

namespace Store.WEB.Controllers
{
    public class HomeController : Controller
    {
        ISaleService saleService;
        public HomeController(ISaleService saleService)
        {
            this.saleService = saleService;
        }
        public ActionResult Index()
        {
            IEnumerable<ProductDTO> productDTOs = saleService.GetProducts();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, ProductViewModel>()).CreateMapper();
            var products = mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(productDTOs);
            return View(products);
        }
        protected override void Dispose(bool disposing)
        {
            saleService.Dispose();
            base.Dispose(disposing);
        }
    }
}
