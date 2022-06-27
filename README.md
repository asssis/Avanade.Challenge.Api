# DESAFIO

### Requisitos

> Desafio.     

* Utilizar os seguintes tipos primitivos (int, bool, datetime, string, arrays (Lista ou Cole��es))
* Ter 1 exemplo de cada pilar de OOP
* Ter 1 exemplo de Design Pattern (Criação, Comportamento ou estrutura)
* Ter um relacionamento entre os objetos (1:1 ou 1:n ou n:n)
* Utilizar um ORM
* Ter um teste de unidade.
* Utlizar o Swagger para documentar a API
* Criar um README.md
* Codigo precisa estar versionado no Github
* Precisa estar fazendo o build através do Github Actions (Continuos Integration)
* Utilizar Conventional Commits

* Criar um FACADE
---
Executando Banco de dados
```
docker run `
-e "ACCEPT_EULA=Y" `
-e "SA_PASSWORD=challenge#passoword" `
-e MSSQL_PID=Developer `
-p 1433:1433 `
-d mcr.microsoft.com/mssql/server:2022-latest

``` 
Testando Banco
```
Banco 
* SQL SERVER
* Server Name: 127.0.0.1, 1433 
* User Name: sa
* Password: challenge#passoword
```
Após disponíbilização do Banco de Dados, precisamos realizar o Migrations. Para isso, execute o comando abaixo.

```
dotnet ef migrations add initialMigration --project .\src\School.API\
```
 
```
dotnet ef database update
```
