FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Defanging-IP-Address/Defanging-IP-Address.csproj", "Defanging-IP-Address/"]
RUN dotnet restore "Defanging-IP-Address/Defanging-IP-Address.csproj"
COPY . .
WORKDIR "/src/Defanging-IP-Address"
RUN dotnet build "Defanging-IP-Address.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Defanging-IP-Address.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Defanging-IP-Address.dll"]
