﻿using FluentValidation;
using System.Collections.Generic;

namespace Application.Catalogs.CatalohItems.AddNewCatalogItem
{
    public class AddNewCatalogItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public int Price { get; set; }
        public int Importance { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public int CatalogTypeId { get; set; }
        public int CatalogBrandId { get; set; }
        public int CatologCarId { get; set; }
        public int CatalogCompanyId { get; set; }
        public int AvailableStock { get; set; }
        public int RestockThreshold { get; set; }
        public int MaxStockThreshold { get; set; }
        public List<AddNewCatalogItemFeature_dto> Features { get; set; }
        public List<AddNewCatalogItemImage_Dto> Images { get; set; }

    }
    public class AddNewCatalogItemDtoValidator: AbstractValidator<AddNewCatalogItemDto>
    {
        public AddNewCatalogItemDtoValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("نام کاتالوگ اجباری است");
            RuleFor(x => x.Name).Length(2, 100);
            RuleFor(x => x.Description).NotNull().WithMessage("توضیحات نمی تواند خالی باشد");
            RuleFor(x => x.AvailableStock).InclusiveBetween(0, int.MaxValue);
            RuleFor(x => x.Price).InclusiveBetween(0, int.MaxValue);
            RuleFor(x => x.Price).NotNull();
        }
    }
}
