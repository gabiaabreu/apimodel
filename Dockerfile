# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# Copy project and restore as distinct layers
COPY RestaurantAPI/ ./
RUN dotnet restore

# Build project to /app/out folder
RUN dotnet publish -c Release -o out

# Stage 2: Run
# runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "RestaurantAPI.dll"]