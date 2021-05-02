using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Test.Data;
using Test.Data.ModalEntity;
using MudBlazor.Services;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using MudBlazor;

namespace Test
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<BookmakerContext>(option => option.UseNpgsql(Configuration.GetConnectionString("AzureConnection")));
			
			services.AddIdentity<User, Role>()
				.AddEntityFrameworkStores<BookmakerContext>()
				.AddDefaultUI()
				.AddDefaultTokenProviders();
			
			services.AddRazorPages();
			services.AddServerSideBlazor();
			services.AddSingleton<WebService>();

			services.AddMudServices(config =>
			{
				config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
				config.SnackbarConfiguration.NewestOnTop = true;
				config.SnackbarConfiguration.ShowCloseIcon = true;
				config.SnackbarConfiguration.VisibleStateDuration = 1000;
				config.SnackbarConfiguration.HideTransitionDuration = 500;
				config.SnackbarConfiguration.ShowTransitionDuration = 500;
				config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
				config.SnackbarConfiguration.MaxDisplayedSnackbars = 3;
			});
			
			services.AddBlazoredLocalStorage();
			services.AddBlazoredSessionStorage();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();
			
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapBlazorHub();
				endpoints.MapFallbackToPage("/_Host");
			});
		}
	}
}
