FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /app

# copy everything else and build app
COPY . .
WORKDIR /app/FilterModule
RUN dotnet build

FROM build AS publish
WORKDIR /app/FilterModule
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.0-runtime AS runtime
WORKDIR /app
COPY --from=publish /app/FilterModule/out ./
ENTRYPOINT ["dotnet", "FilterModule.dll"]
