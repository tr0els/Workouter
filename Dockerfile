FROM mcr.microsoft.com/dotnet/aspnet
WORKDIR /app
COPY ./UI/bin/Debug/net5.0 .
ENTRYPOINT ["dotnet", "UI.dll"]