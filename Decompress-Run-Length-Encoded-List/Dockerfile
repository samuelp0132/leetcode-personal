FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Decompress-Run-Length-Encoded-List/Decompress-Run-Length-Encoded-List.csproj", "Decompress-Run-Length-Encoded-List/"]
RUN dotnet restore "Decompress-Run-Length-Encoded-List/Decompress-Run-Length-Encoded-List.csproj"
COPY . .
WORKDIR "/src/Decompress-Run-Length-Encoded-List"
RUN dotnet build "Decompress-Run-Length-Encoded-List.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Decompress-Run-Length-Encoded-List.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Decompress-Run-Length-Encoded-List.dll"]
