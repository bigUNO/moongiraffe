FROM microsoft/dotnet:2.0-sdk AS build
RUN pwd
WORKDIR /app
RUN ls -lha

# copy everything else and build app
RUN pwd
RUN ls -lha
COPY / .
RUN ls -lha
WORKDIR /app/FilterModule
RUN dotnet build /app/FilterModule.csproj

FROM build AS publish
RUN pwd
RUN ls -lha
WORKDIR /app/FilterModule
RUN pwd
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.0-runtime AS runtime
RUN pwd
RUN ls -lha
COPY --from=publish /app/FilterModule/out ./
ENTRYPOINT ["dotnet", "FilterModule.dll"]
