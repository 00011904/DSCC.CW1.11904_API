#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DSCC.CW1.11904_API/DSCC.CW1.11904_API.csproj", "./"]
RUN dotnet restore "DSCC.CW1.11904_API/DSCC.CW1.11904_API.csproj"
COPY . .
WORKDIR "/src/DSCC.CW1.11904_API"
RUN dotnet build "DSCC.CW1.11904_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DSCC.CW1.11904_API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DSCC.CW1.11904_API.dll"]