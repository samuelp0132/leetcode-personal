FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Kids-With-The-Greatest-Number-With-Candies/Kids-With-The-Greatest-Number-With-Candies.csproj", "Kids-With-The-Greatest-Number-With-Candies/"]
RUN dotnet restore "Kids-With-The-Greatest-Number-With-Candies/Kids-With-The-Greatest-Number-With-Candies.csproj"
COPY . .
WORKDIR "/src/Kids-With-The-Greatest-Number-With-Candies"
RUN dotnet build "Kids-With-The-Greatest-Number-With-Candies.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kids-With-The-Greatest-Number-With-Candies.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kids-With-The-Greatest-Number-With-Candies.dll"]
