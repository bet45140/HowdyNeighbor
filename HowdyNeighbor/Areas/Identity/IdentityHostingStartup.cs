using System;
using HowdyNeighbor.Areas.Identity.Data;
using HowdyNeighbor.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(HowdyNeighbor.Areas.Identity.IdentityHostingStartup))]
namespace HowdyNeighbor.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<HowdyNeighborContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("HowdyNeighborContext")));

                services.AddDefaultIdentity<HowdyNeighborUser>()
                    .AddEntityFrameworkStores<HowdyNeighborContext>();
            });
        }
    }
}