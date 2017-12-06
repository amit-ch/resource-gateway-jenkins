FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

ENV HTTP_PROXY=http://10.16.3.231:80
ENV HTTPS_PROXY=http://10.16.3.231:80

# Copy csproj and restore as distinct layers
COPY ./src/ ./
RUN dotnet restore

# Copy everything else and build
COPY ./src/ ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/**/out ./
ENTRYPOINT ["dotnet", "GatewayAssets.Web.dll"]
