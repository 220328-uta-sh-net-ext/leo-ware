using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using HappySpoonBL;
using HappySpoonDL;
using System.Text;
using Microsoft.OpenApi.Models;
using System.Reflection;
using HappySpoonAPI.Repo;
using Microsoft.Extensions.PlatformAbstractions;

            var builder = WebApplication.CreateBuilder(args);

            ConfigurationManager Config = builder.Configuration;
            

            // Add services to the container.

            builder.Services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(o => {
                var jwtKey = Encoding.UTF8.GetBytes(Config["JWT:Key"]);
                o.SaveToken = true;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Config["JWT:Issuer"],
                    ValidAudience = Config["JWT:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(jwtKey),
                    ValidateLifetime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            builder.Services.AddMemoryCache();
            builder.Services.AddControllers(options =>
                options.RespectBrowserAcceptHeader = true
                )
                .AddXmlSerializerFormatters();

            builder.Services.AddControllers();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description = "JWT Auth using Bearer token",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                            { Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" } },
                        Array.Empty<string>()
                    }
                });
                /*var BaseDirectory = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));*/

            });


            builder.Services.AddScoped<ILogic, Logic>();
            builder.Services.AddScoped<IRepo>(repo => new Repo(Config.GetConnectionString("HPConnectionString")));
            builder.Services.AddScoped<IJWTRepo, JWTRepo>();

            //this app variable refers to thye middleware pipeline

            var app = builder.Build();

            app.Logger.LogInformation("Start App");

            // Configure the HTTP request pipeline.

            if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "RestaurantAPI");
                    c.InjectStylesheet("/swagger-ui/SwaggerDark.css");
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();