using Microsoft.Extensions.DependencyInjection;
using NorthWind.NorthWindDB.Entites.LogEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.ORM
{
   public static class DbCreateService
    {
        public static void AddDbCreate<TDataBaseOperation>(this IServiceCollection services) where TDataBaseOperation:class,IDatabaseOperation,new()
        {
            services.AddScoped<IDatabaseOperation, TDataBaseOperation>();
            TDataBaseOperation dataBaseOperation = new TDataBaseOperation();
            bool isCreate=dataBaseOperation.CreateDatabase();
            if (isCreate)
            {
                dataBaseOperation.CreateTable<RequestLog>();
                dataBaseOperation.CreateTable<ResponseLog>();
            }
        }
    }
}
