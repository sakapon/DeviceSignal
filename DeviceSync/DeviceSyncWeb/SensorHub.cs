using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace DeviceSyncWeb
{
    public class SensorHub : Hub
    {
        public void UpdateOrientation(double alpha, double beta, double gamma)
        {
            Clients.Others.NotifyOrientation(alpha, beta, gamma);
        }
    }
}
