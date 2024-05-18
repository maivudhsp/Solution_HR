﻿using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence
{
    public static class PersistenServiceRegistration
    {
        public static IServiceCollection AddPersistenceService(IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<HrDatabaseContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("HrDatabaseConnectionString"));
            });
            return services;
        }
    }
}
