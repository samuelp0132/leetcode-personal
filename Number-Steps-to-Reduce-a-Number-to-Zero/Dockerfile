FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Number-Steps-to-Reduce-a-Number-to-Zero/Number-Steps-to-Reduce-a-Number-to-Zero.csproj", "Number-Steps-to-Reduce-a-Number-to-Zero/"]
RUN dotnet restore "Number-Steps-to-Reduce-a-Number-to-Zero/Number-Steps-to-Reduce-a-Number-to-Zero.csproj"
COPY . .
WORKDIR "/src/Number-Steps-to-Reduce-a-Number-to-Zero"
RUN dotnet build "Number-Steps-to-Reduce-a-Number-to-Zero.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Number-Steps-to-Reduce-a-Number-to-Zero.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Number-Steps-to-Reduce-a-Number-to-Zero.dll"]
