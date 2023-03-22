FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Maximum-Number-Of-Words-Found-In-Sentences/Maximum-Number-Of-Words-Found-In-Sentences.csproj", "Maximum-Number-Of-Words-Found-In-Sentences/"]
RUN dotnet restore "Maximum-Number-Of-Words-Found-In-Sentences/Maximum-Number-Of-Words-Found-In-Sentences.csproj"
COPY . .
WORKDIR "/src/Maximum-Number-Of-Words-Found-In-Sentences"
RUN dotnet build "Maximum-Number-Of-Words-Found-In-Sentences.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Maximum-Number-Of-Words-Found-In-Sentences.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Maximum-Number-Of-Words-Found-In-Sentences.dll"]
