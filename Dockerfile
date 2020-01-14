FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src

COPY ["Group15.EventManager/Server/Group15.EventManager.Server.csproj", "Group15.EventManager/Server/"]
COPY ["Group15.EventManager/Client/Group15.EventManager.Client.csproj", "Group15.EventManager/Client/"]
COPY ["Group15.EventManager/Shared/Group15.EventManager.Shared.csproj", "Group15.EventManager/Shared/"]
COPY ["Group15.EventManager.Application/Group15.EventManager.ApplicationLayer.csproj", "Group15.EventManager.Application/"]
COPY ["Group15.EventManager.Domain/Group15.EventManager.Domain.csproj", "Group15.EventManager.Domain/"]
COPY ["Group15.EventManager.Domain.Models/Group15.EventManager.Domain.Models.csproj", "Group15.EventManager.Domain.Models/"]
COPY ["Group15.EventManager.Domain.Core/Group15.EventManager.Domain.Core.csproj", "Group15.EventManager.Domain.Core/"]
COPY ["Group15.EventManager.Data/Group15.EventManager.Data.csproj", "Group15.EventManager.Data/"]
COPY ["Group15.EventManager.Bootstrapper/Group15.EventManager.Bootstrapper.csproj", "Group15.EventManager.Bootstrapper/"

RUN dotnet restore "Group15.EventManager/Server/Group15.EventManager.Server.csproj"
COPY . .

RUN dotnet build "Group15.EventManager.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Group15.EventManager.Server.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /src/publish/Group15.EventManager.Server/dist .
COPY nginx.conf /etc/nginx/nginx.conf