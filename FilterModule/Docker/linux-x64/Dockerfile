FROM microsoft/dotnet:2.0.0-runtime-stretch

ARG EXE_DIR=.

WORKDIR /app

COPY $EXE_DIR/ ./

CMD tree

CMD ["dotnet", "publish", "FilterModule.csproj"]

CMD tree

CMD ["dotnet", "FilterModule.dll"]

CMD tree
CMD ["echo" "bye-bye"]