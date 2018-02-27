FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /app
RUN ls -lha

# copy everything else and build app
COPY / .
WORKDIR /app/FilterModule
RUN dotnet build FilterModule.csproj
RUN pwd
RUN ls -lha

FROM build AS publish
WORKDIR /app/FilterModule
RUN pwd
RUN dotnet publish -c Release -o out
RUN pwd
RUN ls -lha

FROM microsoft/dotnet:2.0-runtime AS runtime
RUN pwd
RUN ls -lha
COPY --from=publish /app/FilterModule/out ./
ENTRYPOINT ["dotnet", "FilterModule.dll"]
