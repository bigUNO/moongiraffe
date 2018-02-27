FROM microsoft/dotnet:2.0-sdk AS build
RUN pwd
WORKDIR /app
RUN ls -lha

# copy everything else and build app
RUN pwd
RUN ls -lha
COPY ./../../FilterModule .
RUN ls -lha
RUN dotnet build FilterModule.csproj

FROM build AS publish
RUN pwd
RUN ls -lha
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.0-runtime AS runtime
RUN pwd
RUN ls -lha
COPY --from=publish /app/out ./
ENTRYPOINT ["dotnet", "FilterModule.dll"]
