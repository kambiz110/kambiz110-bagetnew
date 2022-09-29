using Application.Interfaces.Contexts;
using Common.Useful;
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
                BrowserFamily = request.Browser.Family,
                BrowserVersion = request.Browser.Version,
                PhysicalPath = request.PhysicalPath,
                Protocol = request.Protocol,
                ReferrerLink = request.ReferrerLink,
                VisitorId = request.VisitorId,
                Time = DateTime.Now,
                OperationSystemFamily= request.OperationSystem.Family,
                OperationSystemVersion= request.OperationSystem.Version
            };
           
            _dataBaseContext.Visitors.Add(visitor);

            var dt = DateTime.Now.ToPersianDateTime();
            var lastMonthLog = _dataBaseContext.MonthLogs.Where(p => p.yeaar == dt.Year && p.Monthh == dt.Month).FirstOrDefault();
            if (lastMonthLog!=null)
            {
                lastMonthLog.CountLog += 1;
                lastMonthLog.UpdateTime = DateTime.Now;
            }
            else
            {
                _dataBaseContext.MonthLogs.Add(new Domain.Logs.MonthLog { yeaar= dt.Year , Monthh = dt.Month, CountLog=1 }) ;
            }
            _dataBaseContext.SaveChanges();
        }
    }
}
