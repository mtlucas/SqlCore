FROM microsoft/aspnetcore:1.0.1
MAINTAINER mike@lucasnet.org
ENTRYPOINT dotnet /app/SqlCore.dll
WORKDIR /app
COPY bin/Debug/netcoreapp1.0/publish/ /app/
EXPOSE 5000/tcp
