FROM mcr.microsoft.com/dotnet/sdk:6.0 AS publish
WORKDIR /src
COPY Ceilingfish.TimesTableFreestyle.csproj .
RUN dotnet restore Ceilingfish.TimesTableFreestyle.csproj
COPY . .
RUN dotnet publish Ceilingfish.TimesTableFreestyle.csproj -c Release -o /app/publish

FROM nginx as final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .