#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/sunucuTest/WebAPI/WebAPI.csproj", "src/sunucuTest/WebAPI/"]
COPY ["src/sunucuTest/Application/Application.csproj", "src/sunucuTest/Application/"]
COPY ["src/sunucuTest/Domain/Domain.csproj", "src/sunucuTest/Domain/"]
COPY ["src/sunucuTest/Infrastructure/Infrastructure.csproj", "src/sunucuTest/Infrastructure/"]
COPY ["src/sunucuTest/Persistence/Persistence.csproj", "src/sunucuTest/Persistence/"]
RUN dotnet restore "./src/sunucuTest/WebAPI/./WebAPI.csproj"
COPY . .
WORKDIR "/src/src/sunucuTest/WebAPI"
RUN dotnet build "./WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAPI.dll"]