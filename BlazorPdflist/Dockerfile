FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BlazorPdflist/BlazorPdflist.csproj", "BlazorPdflist/"]
RUN dotnet restore "BlazorPdflist/BlazorPdflist.csproj"
COPY . .
WORKDIR "/src/BlazorPdflist"
RUN dotnet build "BlazorPdflist.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorPdflist.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorPdflist.dll"]
