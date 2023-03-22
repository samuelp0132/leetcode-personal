FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Build-Array-From-Permutation/Build-Array-From-Permutation.csproj", "Build-Array-From-Permutation/"]
RUN dotnet restore "Build-Array-From-Permutation/Build-Array-From-Permutation.csproj"
COPY . .
WORKDIR "/src/Build-Array-From-Permutation"
RUN dotnet build "Build-Array-From-Permutation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Build-Array-From-Permutation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Build-Array-From-Permutation.dll"]
