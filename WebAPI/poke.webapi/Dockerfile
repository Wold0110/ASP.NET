#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["poke.webapi/poke.webapi.csproj", "poke.webapi/"]
RUN dotnet restore "poke.webapi/poke.webapi.csproj"
COPY . .
WORKDIR "/src/poke.webapi"
RUN dotnet build "poke.webapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "poke.webapi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "poke.webapi.dll"]