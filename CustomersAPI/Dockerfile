#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY CustomersAPI.csproj CustomersAPI/
RUN dotnet restore CustomersAPI/CustomersAPI.csproj
COPY . CustomersAPI/
WORKDIR /src/CustomersAPI
RUN dotnet build CustomersAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish CustomersAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CustomersAPI.dll"]