using BLL;
using BLL.IServices;
using BLL.Services;
using BLL.Utils;
using Data;
using Data.IRepositories;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Root
{
    /// <summary>
    /// The composition root.
    /// </summary>
    public class CompositionRoot
    {
        /// <summary>
        /// Inject the dependencies.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="connectionString">The connection string.</param>
        public static void InjectDependencies(IServiceCollection services, string connectionString )
        {

            #region // Databases injection

            services.AddDbContext<MyDbContext>(opts => opts.UseSqlServer(connectionString, b => b.MigrationsAssembly("Data")));
            services.AddScoped<MyDbContext>();

            #endregion

            #region // UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();  
            #endregion

            #region // Generic repositories and services injection

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IServicePattern<>), typeof(ServicePattern<>));

            #endregion

            #region // Repositories injection

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IProprietaireRepository, ProprietaireRepository>();
            services.AddScoped<ICommercialRepository, CommercialRepository>();
            services.AddScoped<ILocataireRepository, LocataireRepository>();


            #endregion

            #region // Services injection

            // Utils services
            services.AddScoped<IPasswordEnryptorDecryptor, PasswordEnryptorDecryptor>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

            // Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IProprietaireService, ProprietaireService>();
            services.AddScoped<ICommercialService, CommercialService>();
            services.AddScoped<ILocataireService, LocataireService>();

            #endregion

        }

    }
}
