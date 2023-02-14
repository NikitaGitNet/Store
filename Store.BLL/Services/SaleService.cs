using AutoMapper;
using Store.BLL.BusinessModels;
using Store.BLL.DTO;
using Store.BLL.Infrastructure;
using Store.BLL.Interfaces;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.Services
{
    internal class SaleService : ISaleService
    {
        IUnitOfWork Database { get; set; }

        public SaleService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void MakeSale(SaleDTO saleDto)
        {
            Product product = Database.Products.Get(saleDto.ProductId);

            // валидация
            if (product == null)
                throw new ValidationException("Продукт не найден", "");
            // применяем скидку
            decimal sum = new Discount(0.1m).GetDiscountedPrice(product.Price);
            Sale sale = new Sale
            {
                ProductId = product.Id,
                ProductName = product.Name,
                DateOfSale = DateTime.Now,
                TitleImagePath= product.TitleImagePath,
                Price = product.Price
            };
            Database.Sales.Create(sale);
            Database.Save();
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Product>, List<ProductDTO>>(Database.Products.GetAll());
        }

        public ProductDTO GetProduct(Guid id)
        {
            if (id == default)
                throw new ValidationException("Не установлено id продукта", "");
            var product = Database.Products.Get(id);
            if (product == null)
                throw new ValidationException("Продукт не найден", "");

            return new ProductDTO { BrandName = product.BrandName, ClothingTypeName = product.ClothingTypeName, TitleImagePath = product.TitleImagePath, Id = product.Id, SizeName = product.SizeName, Name = product.Name, Price = product.Price };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
