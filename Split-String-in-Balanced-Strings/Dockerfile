FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Split-String-in-Balanced-Strings/Split-String-in-Balanced-Strings.csproj", "Split-String-in-Balanced-Strings/"]
RUN dotnet restore "Split-String-in-Balanced-Strings/Split-String-in-Balanced-Strings.csproj"
COPY . .
WORKDIR "/src/Split-String-in-Balanced-Strings"
RUN dotnet build "Split-String-in-Balanced-Strings.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Split-String-in-Balanced-Strings.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Split-String-in-Balanced-Strings.dll"]
