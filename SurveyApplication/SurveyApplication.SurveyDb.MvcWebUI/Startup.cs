
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.Business.Concrete;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework;
using SurveyApplication.SurveyDb.MvcWebUI.Middlewares;
using SurveyApplication.SurveyDb.MvcWebUI.Security;


namespace SurveyApplication.SurveyDb.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonManager>();
            services.AddScoped<IPersonDal, EfPersonDal>();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserDal>();

            services.AddScoped<IManagerService, ManagerManager>();
            services.AddScoped<IManagerDal, EfManagerDal>();


            services.AddScoped<ISurveyService, SurveyManager>();
            services.AddScoped<ISurveyDal, EfSurveyDal>();

            services.AddScoped<IQuestionService, QuestionManager>();
            services.AddScoped<IQuestionDal, EfQuestionDal>();

            services.AddScoped<IQuestionOptionService, QuestionOptionManager>();
            services.AddScoped<IQuestionOptionsDal,EfQuestionOptionDal >();

            services.AddScoped<IAnswerService, AnswerManager>();
            services.AddScoped<IAnswerDal, EfAnswerDal>();

            services.AddScoped<IGroupService, GroupManager>();
            services.AddScoped<IGroupDal, EfGroupDal>();

            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<ICityDal, EfCityDal>();

            services.AddScoped<IGenderService, GenderManager>();
            services.AddScoped<IGenderDal, EfGenderDal>();

            services.AddScoped<IPersonUserService, PersonUserManager>();
            services.AddScoped<IPersonUserDal, EfPersonUserDal>();

            services.AddScoped<ICipherService, Security.Security>();


            services.AddSession();
            services.AddDistributedMemoryCache();

            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);
            app.UseSession();
            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            
            routeBuilder.MapRoute("Default", "{controller=Account}/{action=Login}");
        }
    }
}
