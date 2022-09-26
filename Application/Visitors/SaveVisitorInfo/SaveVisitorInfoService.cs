using Application.Interfaces.Contexts;
using Domain.Visitors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Visitors.SaveVisitorInfo
{
    public class SaveVisitorInfoService : ISaveVisitorInfoService
    {
        private readonly IDataBaseContext _dataBaseContext;

        public SaveVisitorInfoService(IDataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public void Execute(RequestSaveVisitorInfoDto request)
        {
            var visitor = new Visitor
            {
                CurrentLink = request.CurrentLink,
                DeviceBrand = request.Device.Brand,
                DeviceFamily = request.Device.Family,
                DeviceIsSpider = request.Device.IsSpider,
                DeviceModel = request.Device.Model,
                Ip = request.Ip,
                Method = request.Method,
                VisitorVersionFamily = request.OperationSystem.Family,
                VisitorVersionVersion = request.OperationSystem.Version,
                PhysicalPath = request.PhysicalPath,
                Protocol = request.Protocol,
                ReferrerLink = request.ReferrerLink,
                VisitorId = request.VisitorId,
                Time = DateTime.Now,
            };
            _dataBaseContext.Visitors.Add(visitor);
            _dataBaseContext.SaveChanges();
        }
    }
}
