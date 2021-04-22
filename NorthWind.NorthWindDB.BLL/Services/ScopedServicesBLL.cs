using Microsoft.Extensions.DependencyInjection;
using NorthWind.NorthWindDB.BLL.LogManager.Abstract;
using NorthWind.NorthWindDB.BLL.LogManager.Concrete;
using NorthWind.NorthWindDB.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.BLL.Services
{
    public static class ScopedServicesBLL
    {
        public static void AddScopedObjects(this IServiceCollection services)
        {
            services.AddScopedDAL();
            services.AddScoped<IRequestLogBLL, RequestLogBLL>();
            services.AddScoped<IResponseLogBLL, ResponseLogBLL>();
        }
    }
}
