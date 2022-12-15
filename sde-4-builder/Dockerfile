FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /sde-4-builder

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /sde-4-builder
COPY --from=build-env /sde-4-builder/out .
ENTRYPOINT ["dotnet", "sde-4-builder.dll"]