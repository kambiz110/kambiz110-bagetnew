using Application.Interfaces.Contexts;
using Application.Users.Dto;
using AutoMapper;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users
{

    public interface IUserAddressService
    {
        List<UserAddressDto> GetAddress(string UserId);
        void AddnewAddress(AddUserAddressDto address);
        AddUserAddressDto GetForEdit(int id, string userId);
        void EditAddress(AddUserAddressDto dto);
    }

    public class UserAddressService : IUserAddressService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public UserAddressService(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void AddnewAddress(AddUserAddressDto address)
        {
            var data = mapper.Map<UserAddress>(address);
            context.UserAddresses.Add(data);
            context.SaveChanges();
        }
        public void EditAddress(AddUserAddressDto dto)
        {
            var UserAddress = context.UserAddresses.Where(p => p.Id == dto.Id && p.UserId ==dto.UserId).FirstOrDefault();
            if (UserAddress!=null)
            {
     var data = mapper.Map(dto, UserAddress);
            context.UserAddresses.Update(data);
            context.SaveChanges();
            }
       
        }
        public AddUserAddressDto GetForEdit(int id , string userId)
        {
            var address = context.UserAddresses.Where(p => p.Id == id && p.UserId == userId).FirstOrDefault(); 
            if (address!=null)
            {
                var data = mapper.Map<AddUserAddressDto>(address);
                return data;
            }
            return new AddUserAddressDto();
        }
        public List<UserAddressDto> GetAddress(string UserId)
        {
            var address = context.UserAddresses.Where(p => p.UserId == UserId);
            var data = mapper.Map<List<UserAddressDto>>(address);
            return data;
        }
    }


    public class UserAddressDto
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PostalAddress { get; set; }
        public string ReciverName { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class AddUserAddressDto
    {
        public int Id { get; set; } = 0;
        [Display(Name = "شهر ")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string City { get; set; }
        [Required(ErrorMessage = "نام استان را وارد نمایید")]
        public string State { get; set; }
        [Display(Name = "کد پستی")]
        [DataType(DataType.PostalCode)]
        [RegularExpression(pattern: @"\b(?!(\d)\1{3})[13-9]{4}[1346-9][013-9]{5}\b" ,ErrorMessage =  "کد پستی شما نادرست می‌باشد")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "آدرس کامل را وارد نمایید")]
        public string PostalAddress { get; set; }
        [Required(ErrorMessage = "نام دریافت کننده را وارد نمایید")]
        public string ReciverName { get; set; }

        public string UserId { get; set; }
        [MobliPhon]
        [Display(Name = "شماره موبایل ")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string PhoneNumber { get; set; }
    }
}
