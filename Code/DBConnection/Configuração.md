# Instalando e Configurando o Banco de Dados SQL Server (Linux)

1. Obtendo o Linux contêiner image de Microsoft Container Registry:

```
sudo docker pull mcr.microsoft.com/mssql/server:2019-latest
```

2. Para executar a imagem do contêiner com o Docker, você pode usar o seguinte comando:

```
sudo docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=SENHA" -p 1433:1433 --name sql1 -h sql1 -d mcr.microsoft.com/mssql/server:2019-latest
```

**Observação**: Você deve usar uma senha forte.

3. Para visualizar seus contêineres do Docker, use o comando:

```
sudo docker ps -a
```

## Conectando com o SQL Server

1. Use o seguinte comando para iniciar um shell bash interativo dentro do contêiner em execução. No exemplo a seguir, `sql1` é o nome especificado pelo parâmetro `--name` quando você criou o contêiner.

```
sudo docker exec -it sql1 "bash"
```

2. Uma vez dentro do contêiner, conecte-se localmente com sqlcmd. Sqlcmd não está no caminho por padrão, então você deve especificar o caminho completo.

```
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "SENHA"
```

3. Se for bem-sucedido, você deverá obter um prompt de comando sqlcmd: `1>`.

## Criar e Consultar Dados

### Criando um novo Banco de Dados

As etapas a seguir criam um novo banco de dados denominado `TestDB`.

1. No prompt de comando sqlcmd, cole o seguinte comando Transact-SQL para criar um banco de dados de teste:

```SQL 
CREATE DATABASE TestDB
```

2. Na próxima linha, escreva uma consulta para retornar o nome de todos os bancos de dados em seu servidor:

```SQL
SELECT Name from sys.Databases
```

3. Os dois comandos anteriores não foram executados imediatamente. Digite `GO` em uma nova linha para executar os comandos anteriores:

```SQL
GO
```

### Inserir Dados

Em seguida, crie uma nova tabela, Inventory, e insira duas novas linhas.

1. No prompt de comando sqlcmd, mude o contexto para o novo banco de dados `TestDB`:

```SQL
USE TestDB
```

2. Crie uma nova tabela chamada `Inventory`:

```SQL
CREATE TABLE Inventory (id INT, name NVARCHAR(50), quantity INT)
```

3. Insira dados nessa nova tabela:

```SQL
INSERT INTO Inventory VALUES (1, 'banana', 150); INSERT INTO Inventory VALUES (2, 'orange', 154);
```

4. Digite GO para executar os comandos anteriores:

```SQL
GO
```

### Selecionar Dados

Agora, execute uma consulta para retornar dados da tabela `Inventory`.

1. No prompt de comando sqlcmd, insira uma consulta que retorne linhas da tabela `Inventory` em que a quantidade seja maior que 152:

```SQL
SELECT * FROM Inventory WHERE quantity > 152;
```

2. Execute o comando:

```SQL
GO
```

### Saia do Prompt de Comando sqlcmd

1. Para encerrar sua sessão sqlcmd, digite `QUIT`:

```SQL
QUIT
```

2. Para sair do prompt de comando interativo em seu contêiner, digite `exit`. Seu contêiner continua a ser executado depois que você sai do shell bash interativo.

### Removendo o Contêiner

Se você deseja remover o contêiner do SQL Server usado neste tutorial, execute os seguintes comandos:

```
sudo docker stop sql1
sudo docker rm sql1
```

Parar e remover um contêiner exclui permanentemente todos os dados do SQL Server no contêiner. Se você precisar preservar seus dados, crie e copie um arquivo de backup do contêiner ou use uma técnica de persistência de dados do contêiner.

## Referência

- https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker