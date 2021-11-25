FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebPdflist/WebPdflist.csproj", "WebPdflist/"]
RUN dotnet restore "WebPdflist/WebPdflist.csproj"
COPY . .
WORKDIR "/src/WebPdflist"
RUN dotnet build "WebPdflist.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebPdflist.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebPdflist.dll"]
