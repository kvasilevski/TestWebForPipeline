FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["TestWebForPipeline/TestWebForPipeline.csproj", "TestWebForPipeline/"]
COPY ["Domain/Domain.csproj", "Domain/"]
RUN dotnet restore "TestWebForPipeline/TestWebForPipeline.csproj"
COPY . .
WORKDIR "/src/TestWebForPipeline"
RUN dotnet build "TestWebForPipeline.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TestWebForPipeline.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TestWebForPipeline.dll"]