using AutoMapper;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.Mapped.ViewModels.CategoryViewModels;
using ShoppingCart.Mapped.ViewModels.ProductViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Web.Helper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            //Category
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Category, EditCategoryViewModel>().ReverseMap();
            CreateMap<Category, DetailCategoryViewModel>();
            CreateMap<Category, DeleteCategoryViewModel>().ReverseMap();
            CreateMap<CreateCategoryViewModel, Category>();

            //Products
            CreateMap<Product, ProductViewModel>();
            CreateMap<Product, ProductDetailViewModel>().
                ForMember(p => p.CategoryNames, p => p.MapFrom(p => p.Categories.Select(p => p.Category).ToList()));
            CreateMap<ProductPostViewModel, Product>();

        }
    }
}
