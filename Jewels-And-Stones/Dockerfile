FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Jewels-And-Stones/Jewels-And-Stones.csproj", "Jewels-And-Stones/"]
RUN dotnet restore "Jewels-And-Stones/Jewels-And-Stones.csproj"
COPY . .
WORKDIR "/src/Jewels-And-Stones"
RUN dotnet build "Jewels-And-Stones.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Jewels-And-Stones.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Jewels-And-Stones.dll"]
