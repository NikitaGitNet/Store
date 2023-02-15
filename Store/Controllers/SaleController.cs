using Microsoft.AspNetCore.Mvc;
using Store.BLL.DTO;
using Store.BLL.Interfaces;
using Store.WEB.Models;
using System.ComponentModel.DataAnnotations;

namespace Store.WEB.Controllers
{
    public class SaleController : Controller
    {
        ISaleService saleService;
        public SaleController(ISaleService saleService)
        {
            this.saleService = saleService;
        }
        public ActionResult MakeSale(Guid id)
        {
            try
            {
                ProductDTO product = saleService.GetProduct(id);
                var sale = new SaleViewModel { ProductId = product.Id };

                return View(sale);
            }
            catch (ValidationException ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult MakeSale(SaleViewModel sale)
        {
            try
            {
                var saleDto = new SaleDTO { EmployeeName = sale.EmployeeName, DateOfSale = sale.DateOfSale, Id = sale.Id, Price = sale.Price, ProductId = sale.ProductId, ProductName = sale.ProductName, TitleImagePath = sale.TitleImagePath};
                saleService.MakeSale(saleDto);
                return Content("<h2>Ваш заказ успешно оформлен</h2>");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }
            return View(sale);
        }
        protected override void Dispose(bool disposing)
        {
            saleService.Dispose();
            base.Dispose(disposing);
        }
    }
}
