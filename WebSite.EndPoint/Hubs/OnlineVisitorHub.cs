using Microsoft.AspNetCore.SignalR;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Hubs
{
    public class OnlineVisitorHub : Hub
    {
        //private readonly IIVisitorOnlineService visitorOnlineService;
        private readonly InMemoryContext _inMemoryContext;
        public OnlineVisitorHub(/*IIVisitorOnlineService visitorOnlineService,*/
            InMemoryContext inMemoryContext)
        {
            //this.visitorOnlineService = visitorOnlineService;
            _inMemoryContext = inMemoryContext;
        }
        public override Task OnConnectedAsync()
        {
            string VisitorId = Context.GetHttpContext().Request.Cookies["VisitorId"];
            //visitorOnlineService.ConnectUser(VisitorId);
            if (!_inMemoryContext.OnlineVisitors.Where(p=>p.Id== VisitorId).Any())
            {
            _inMemoryContext.OnlineVisitors.Add(new Domain.Visitors.OnlineVisitor { 
            ClientId= VisitorId,
            Id= VisitorId,
            Time=DateTime.Now
            });
            _inMemoryContext.SaveChanges();
            }
        
            var onlineInMemoreUser = _inMemoryContext.OnlineVisitors.ToList();
            //var count = visitorOnlineService.GetCount();
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            string VisitorId = Context.GetHttpContext().Request.Cookies["VisitorId"];

            //visitorOnlineService.DisConnectUser(VisitorId);
            //var count = visitorOnlineService.GetCount();
            if (_inMemoryContext.OnlineVisitors.Where(p => p.Id == VisitorId).Any())
            { 
                      _inMemoryContext.OnlineVisitors.Remove(new Domain.Visitors.OnlineVisitor
            {
                ClientId = VisitorId,
                Id = VisitorId,
            });
            _inMemoryContext.SaveChanges();
            }
      
            var onlineInMemoreUser = _inMemoryContext.OnlineVisitors.ToList();
            return base.OnDisconnectedAsync(exception);
        }
    }
}
