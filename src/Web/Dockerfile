#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Clean_eCommerce/Clean_eCommerce.csproj", "Clean_eCommerce/"]
RUN dotnet restore "Clean_eCommerce/Clean_eCommerce.csproj"
COPY . .
WORKDIR "/src/Clean_eCommerce"
RUN dotnet build "Clean_eCommerce.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Clean_eCommerce.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Clean_eCommerce.dll"]