/*

Este projeto é o desenvolvimento back-end de uma WebAPI para gerenciar coleções de itens(CD's,DVD's e Livros).

Para executá-lo, é necessário realizar as seguintes operações:

---------------------------------------------------------

1- Clonar ou realizar o download do Repositório.

2- Abrir a solução no Visual Studio

3- Abrir o Console de Gerenciador de Pacotes (Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes)


4- Instalar o EntityFramework Core colando no terminal o seguinte comando

   Install-Package Microsoft.EntityFrameworkCore -Version 5.0.0-preview.3.20181.2
   

5- Criar um Banco de Dados SQL (Ferramentas > Add SQL Server > Local > MSSQLLocalDB)

6- Alterar a String de conexão do banco no arquivo "appsettings.json" / Ex: "DefaultConnection":"sua string de conexão".

7- No Console de Gereciador de Pacotes, executar o comando: EntityFrameworkCore\Update-Database

Após isso, faça o build do projeto teclando F6 e execute a solução teclando F5.

*/