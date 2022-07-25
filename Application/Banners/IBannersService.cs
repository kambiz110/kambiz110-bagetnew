using Application.Dtos;
using Domain.Banners;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Application.Banners
{
    public interface IBannersService
    {
        void AddBanner(BannerDto banner);
        BaseDto Remove(int Id);
        BaseDto<BannerDto> Edit(BannerDto dto);
        BaseDto<BannerDto> FindById(int Id);
        PaginatedItemsDto<BannerDto> GetList(int page, int pageSize);
    }


    public class BannerDto
    {
        public int Id { get; set; }
        [Display(Name = "نام بنر")]
        public string Name { get; set; }
        [Display(Name = "توضیحات بنر")]
        public string Description { get; set; }
        [Display(Name = "تصویر بنر")]
        public string Image { get; set; }
        [ValidateNever]
        public string ShowImage { get; set; }
        [ValidateNever]
        public string Link { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }
        [Display(Name = "موقعیت نمایش")]
        public Position Position { get; set; }
        [Display(Name = "ترتیب نمایش")]
        public int Priority { get; set; }

        [Display(Name = "شناسه یکتا لینک")]
        public int UniqKey { get; set; }
        [Display(Name = "ماهیت دسته بندی لینک")]
        public int CategoriType { get; set; }
    }
}
