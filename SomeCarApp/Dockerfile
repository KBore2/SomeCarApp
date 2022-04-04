#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SomeCarApp/SomeCarApp.csproj", "SomeCarApp/"]
COPY ["SomeCarApp.Infrastructure/SomeCarApp.Infrastructure.csproj", "SomeCarApp.Infrastructure/"]
COPY ["SomeCarApp.Domain/SomeCarApp.Domain.csproj", "SomeCarApp.Domain/"]
COPY ["SomeCarApp.Commands/SomeCarApp.Commands.csproj", "SomeCarApp.Commands/"]
COPY ["SomeCarApp.Queries/SomeCarApp.Queries.csproj", "SomeCarApp.Queries/"]
RUN dotnet restore "SomeCarApp/SomeCarApp.csproj"
COPY . .
WORKDIR "/src/SomeCarApp"
RUN dotnet build "SomeCarApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SomeCarApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SomeCarApp.dll"]
