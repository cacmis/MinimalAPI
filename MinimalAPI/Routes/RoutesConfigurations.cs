using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinimalAPI.Services.Interfaces;

namespace MinimalAPI.Routes
{
    public static class RoutesConfigurations
    {
        public static void MapConfigurations(this IEndpointRouteBuilder app)
        {
            app.MapGet("Mensaje",()=> "Hola Mundo");
            app.MapGet("/products",(IProductService service )=>
            {
                return service.GetProducts();
            }
            );
        }
    }
}