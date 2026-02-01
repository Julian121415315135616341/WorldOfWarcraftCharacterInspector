FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base

WORKDIR /app
    
EXPOSE 8082

COPY bin/publish/ .

ENTRYPOINT ["dotnet", "JulianWow.dll"]