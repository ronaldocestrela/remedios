# Etapa 1: Usar uma imagem base para buildar a aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar os arquivos do projeto e restaurar as dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar o resto dos arquivos e compilar o app
COPY . ./
RUN dotnet publish -c Release -o /out

# Etapa 2: Usar uma imagem mais leve para rodar o app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copiar o app buildado da etapa de build
COPY --from=build /out .

# Expôr a porta da aplicação (usualmente 80 ou 5000)
EXPOSE 80

# Definir o comando de entrada para rodar o app
ENTRYPOINT ["dotnet", "ControleDeRemedio.dll"]
