#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 9090
ENV ASPNETCORE_URLS=http://*:9090

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ListaTareas.API/ListaTareas.API.csproj", "ListaTareas.API/"]
COPY ["ListaTareas.Aplicacion/ListaTareas.Aplicacion.csproj", "ListaTareas.Aplicacion/"]
COPY ["ListaTareas.Model/ListaTareas.Model.csproj", "ListaTareas.Model/"]
COPY ["ListaTareas.Repo/ListaTareas.Repo.csproj", "ListaTareas.Repo/"]
RUN dotnet restore "ListaTareas.API/ListaTareas.API.csproj"
COPY . .
WORKDIR "/src/ListaTareas.API"
RUN dotnet build "ListaTareas.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "ListaTareas.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ListaTareas.API.dll"]