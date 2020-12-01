using AutoMapper;
using ShoppingCart.Mapped.Infrastructure;
using ShoppingCart.Mapped.ViewModels.ProductViewModel;
using ShoppingCart.Repo.Infrastructure;
using System;
using System.Collections.Generic;


namespace ShoppingCart.Mapped.Repositories
{
    public class MappedProduct  : IMappedProduct
    {
        private readonly IProduct _productRepo;
        private readonly IMapper _mapper;

        public MappedProduct(IProduct productRepo)
        {
            _productRepo = productRepo;
        }

        public IEnumerable<ProductViewModel> GetAllMappedProducts()
        {
            var vm = _productRepo.GetAllProducts();
            var mappedProducts = _mapper.Map<List<ProductViewModel>>(vm);
            return mappedProducts;
        }

        public ProductViewModel GetMappedProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
