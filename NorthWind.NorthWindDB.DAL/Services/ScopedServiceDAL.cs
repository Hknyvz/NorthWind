using Microsoft.Extensions.DependencyInjection;
using NorthWind.NorthWindDB.DAL.LogDAL.Abstract;
using NorthWind.NorthWindDB.DAL.LogDAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.DAL.Services
{
    public static class ScopedServiceDal
    {
        public static void AddScopedDAL(this IServiceCollection services)
        {
            services.AddScoped<IRequestLogDAL, RequestLogDAL>();
            services.AddScoped<IResponseLogDAL, ResponseLogDAL>();
        }
    }
}
