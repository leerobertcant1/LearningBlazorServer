using System;
using LearningBlazorServer.Areas.Identity.Data;
using LearningBlazorServer.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LearningBlazorServer.Areas.Identity.IdentityHostingStartup))]
namespace LearningBlazorServer.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LearningBlazorServerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LearningBlazorServerContextConnection")));

                services.AddDefaultIdentity<LearningBlazorServerUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<LearningBlazorServerContext>();
            });
        }
    }
}