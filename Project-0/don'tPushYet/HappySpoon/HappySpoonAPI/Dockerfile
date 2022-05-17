#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HappySpoonAPI/HappySpoonAPI.csproj", "HappySpoonAPI/"]
COPY ["HappySpoonDB/HappySpoonDL.csproj", "HappySpoonDB/"]
COPY ["HappySpoonModels/HappySpoonModels.csproj", "HappySpoonModels/"]
COPY ["HappySpoonBL/HappySpoonBL.csproj", "HappySpoonBL/"]
RUN dotnet restore "HappySpoonAPI/HappySpoonAPI.csproj"
COPY . .
WORKDIR "/src/HappySpoonAPI"
RUN dotnet build "HappySpoonAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HappySpoonAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HappySpoonAPI.dll"]