FROM microsoft/dotnet:2.0.0-runtime-stretch

WORKDIR /app

COPY ./FilterModule/bin/Debug/netcoreapp2.0/publish ./

ENTRYPOINT [ "dotnet", "FilterModule.dll" ]
