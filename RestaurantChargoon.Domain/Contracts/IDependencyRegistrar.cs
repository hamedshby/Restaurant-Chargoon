﻿using Microsoft.Extensions.DependencyInjection;

namespace RestaurantChargoon.Domain.Contracts
{
    public interface IDependencyRegistrar
    {
         void ConfigureServices(IServiceCollection services);

    }

}


