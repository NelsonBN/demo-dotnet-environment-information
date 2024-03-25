FROM mcr.microsoft.com/dotnet/sdk:8.0.203 AS build-env

WORKDIR /src

COPY ./src/ .
RUN dotnet publish Demo.csproj \
    -c Release \
    --self-contained true \
    -o /out



FROM mcr.microsoft.com/dotnet/runtime:8.0.3

WORKDIR /app
COPY --from=build-env /out .

USER app

ENTRYPOINT ["dotnet", "Demo.dll"]
