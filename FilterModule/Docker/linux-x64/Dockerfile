FROM microsoft/dotnet:2.0.0-runtime-stretch

WORKDIR /app

RUN dotnet publish FilterModule.csproj

COPY ./FilterModule/bin/Debug/netcoreapp2.0/publish ./

RUN ls

ENTRYPOINT [ "dotnet", "FilterModule.dll" ]