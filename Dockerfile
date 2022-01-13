#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Get Base Image (Full .NET Core SDK)
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

# Copy csproj and restore
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PAUL.csproj", "."]
RUN dotnet restore "./PAUL.csproj"
# Copy everything else and build
COPY . .
WORKDIR "/src/."
RUN dotnet build "PAUL.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PAUL.csproj" -c Release -o /app/publish

# Generate runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
>>>>>>> 942f256ed20c1d651c59fcfed338895ffad4c5dc
ENTRYPOINT ["dotnet", "PAUL.dll"]