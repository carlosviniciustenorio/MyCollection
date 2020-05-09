Este projeto � o desenvolvimento back-end de uma WebAPI para gerenciar cole��es de itens(CD's,DVD's e Livros).

Para execut�-lo, � necess�rio realizar as seguintes opera��es:

1- Clonar ou realizar o download do Reposit�rio.

2- Abrir a solu��o no Visual Studio

3- Abrir o Console de Gerenciador de Pacotes (Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes)

4- Instalar o EntityFramework Core colando no terminal o seguinte comando: Install-Package Microsoft.EntityFrameworkCore -Version 5.0.0-preview.3.20181.2

5- Criar um Banco de Dados SQL (Ferramentas > Add SQL Server > Local > MSSQLLocalDB)

6- Alterar a String de conex�o do banco no arquivo "appsettings.json" / Ex: "DefaultConnection":"sua string de conex�o".

7- No Console de Gereciador de Pacotes, executar o comando: EntityFrameworkCore\Update-Database

Fazendo assim, o banco de dados ser� atualizado com as migra��es do projeto.

Ap�s isso, voc� executa a solu��o teclando F5.