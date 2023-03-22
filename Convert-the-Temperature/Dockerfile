FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Convert-the-Temperature/Convert-the-Temperature.csproj", "Convert-the-Temperature/"]
RUN dotnet restore "Convert-the-Temperature/Convert-the-Temperature.csproj"
COPY . .
WORKDIR "/src/Convert-the-Temperature"
RUN dotnet build "Convert-the-Temperature.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Convert-the-Temperature.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Convert-the-Temperature.dll"]
