# DESAFIO

### Requisitos

> Desafio
> 
* Utilizar os seguintes tipos primitivos (int, bool, datetime, string, arrays (Lista ou Colecões))
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
* Criar Trés padrões de projeto


Detalhes do sistema feito

Esse foi um sistema desenvolvido em asp.net core, onde atraves do spech são pronunciadas frases e você deve escrever as palavras, com isso você pode melhorar o listem.


* Criar um FACADE
* Criar um Singleton
* Criar um Mediator
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
