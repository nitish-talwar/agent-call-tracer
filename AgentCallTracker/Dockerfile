FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY AgentCallTracker/AgentCallTracker.API.csproj AgentCallTracker/
RUN dotnet restore AgentCallTracker/AgentCallTracker.API.csproj
COPY . .
WORKDIR /src/AgentCallTracker
RUN dotnet build AgentCallTracker.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AgentCallTracker.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AgentCallTracker.dll"]
