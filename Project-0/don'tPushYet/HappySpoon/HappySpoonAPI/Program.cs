using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using HappySpoonBL;
using HappySpoonDL;
using System.Text;

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
            builder.Services.AddSwaggerGen();


            builder.Services.AddScoped<ILogic, Logic>();
            builder.Services.AddScoped<IRepo>(repo => new Repo(Config.GetConnectionString("HPConnectionString")));


            //this app variable refers to thye middleware pipeline

            var app = builder.Build();
            app.Logger.LogInformation("Start");

            // Configure the HTTP request pipeline.

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();