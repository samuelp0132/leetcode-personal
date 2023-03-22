FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Concatenation-Of-Array/Concatenation-Of-Array.csproj", "Concatenation-Of-Array/"]
RUN dotnet restore "Concatenation-Of-Array/Concatenation-Of-Array.csproj"
COPY . .
WORKDIR "/src/Concatenation-Of-Array"
RUN dotnet build "Concatenation-Of-Array.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Concatenation-Of-Array.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Concatenation-Of-Array.dll"]
