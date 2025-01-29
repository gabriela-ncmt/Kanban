
# Kanban - Projeto de Aplicação Web

Este projeto é uma aplicação web de **Kanban** que foi desenvolvido com base no tutorial disponível no YouTube: [Kanban Tutorial](https://www.youtube.com/watch?v=na8ZQqj011E).

Créditos a: [CrislaineLuana](https://github.com/CrislaineLuana)

## Funcionalidades

- **Criar e gerenciar tarefas:** Criação de tarefas e atribuição de status como "A Fazer", "Em Progresso" e "Concluído".
- **Organização visual:** Interface gráfica intuitiva para arranjar tarefas entre diferentes colunas.
- **Persistência de dados:** Uso de um banco de dados para salvar as tarefas e seu status.

## Tecnologias Utilizadas

- **Backend:** ASP.NET Core (C#)
- **Frontend:** Razor Pages com HTML/CSS e JavaScript
- **Banco de Dados:** SQL Server (ou um banco de dados relacional similar)
- **Framework de Desenvolvimento:** .NET 8.0 (ou versão mais recente)

## Instalação

Para rodar este projeto localmente, siga as instruções abaixo:

### 1. Clone o repositório

```bash
git clone https://github.com/gabriela-ncmt/Kanban.git
```

### 2. Navegue até o diretório do projeto

```bash
cd Kanban
```

### 3. Restaure os pacotes NuGet

```bash
dotnet restore
```

### 4. Configure a conexão com o banco de dados

Edite o arquivo `appsettings.json` para configurar a string de conexão com seu banco de dados SQL Server (ou outro banco de dados de sua escolha).

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=KanbanDB;Trusted_Connection=True;"
}
```

### 5. Crie o banco de dados e as tabelas

Execute as migrações para configurar o banco de dados:

```bash
dotnet ef database update
```

### 6. Execute o projeto

```bash
dotnet run
```

Acesse a aplicação no navegador através de `http://localhost:7112`.

## Como Usar

1. Na página inicial, você verá as colunas do Kanban ("A Fazer", "Em Progresso", "Concluído").
2. Clique em "Adicionar Tarefa" para criar uma nova tarefa.
3. Arraste e solte as tarefas entre as colunas para mudar seu status.
4. As mudanças serão salvas automaticamente no banco de dados.

## Agradecimentos

- [Tutorial Kanban no YouTube](https://www.youtube.com/watch?v=na8ZQqj011E) – Base para o desenvolvimento deste projeto.
