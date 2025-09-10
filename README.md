# Product Catalog API - Checkpoint Azure .NET

## Descrição
API REST desenvolvida em .NET 8 para gerenciamento de catálogo de produtos, implementando CRUD completo para duas entidades relacionadas: **Categoria** e **Produto**.

## Tecnologias Utilizadas
- .NET 8.0
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger/OpenAPI
- Docker

## Estrutura do Projeto

### Entidades
1. **Categoria**
   - Id (int, chave primária)
   - Nome (string, obrigatório, máx. 100 caracteres)
   - Descrição (string, opcional, máx. 500 caracteres)
   - DataCriacao (DateTime)
   - Produtos (relacionamento 1:N)

2. **Produto**
   - Id (int, chave primária)
   - Nome (string, obrigatório, máx. 200 caracteres)
   - Descrição (string, opcional, máx. 1000 caracteres)
   - Preco (decimal)
   - Estoque (int)
   - DataCriacao (DateTime)
   - CategoriaId (int, chave estrangeira)
   - Categoria (propriedade de navegação)

### Endpoints da API

#### Categorias
- `GET /api/categorias` - Lista todas as categorias
- `GET /api/categorias/{id}` - Busca categoria por ID
- `POST /api/categorias` - Cria nova categoria
- `PUT /api/categorias/{id}` - Atualiza categoria
- `DELETE /api/categorias/{id}` - Remove categoria

#### Produtos
- `GET /api/produtos` - Lista todos os produtos
- `GET /api/produtos/{id}` - Busca produto por ID
- `GET /api/produtos/categoria/{categoriaId}` - Lista produtos por categoria
- `POST /api/produtos` - Cria novo produto
- `PUT /api/produtos/{id}` - Atualiza produto
- `DELETE /api/produtos/{id}` - Remove produto

## Como Executar

### Pré-requisitos
- .NET 8.0 SDK
- SQL Server (local ou Azure SQL)

### Configuração
1. Clone o repositório
2. Configure a string de conexão no `appsettings.json`
3. Execute as migrations: `dotnet ef database update`
4. Execute a aplicação: `dotnet run`

### Docker
1. Build da imagem: `docker build -t product-catalog-api .`
2. Execute o container: `docker run -p 5000:5000 product-catalog-api`

## Documentação da API
Acesse `/swagger` para visualizar a documentação interativa da API.

## Dados Iniciais
A aplicação inclui dados de exemplo:
- 2 categorias: Eletrônicos e Roupas
- 3 produtos: Smartphone, Notebook e Camiseta

## Estrutura de Arquivos
```
ProductCatalogAPI/
├── Controllers/
│   ├── CategoriasController.cs
│   └── ProdutosController.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Models/
│   ├── Categoria.cs
│   └── Produto.cs
├── Dockerfile
├── Program.cs
├── appsettings.json
└── ProductCatalogAPI.csproj
```

## Funcionalidades Implementadas
- ✅ CRUD completo para Categorias
- ✅ CRUD completo para Produtos
- ✅ Relacionamento entre entidades
- ✅ Validação de dados
- ✅ Documentação Swagger
- ✅ Configuração CORS
- ✅ Containerização Docker
- ✅ Dados iniciais (seed)

## Configuração para Azure
Para deploy no Azure, configure:
1. Azure SQL Database
2. Azure Container Registry
3. Azure Container Instances

A string de conexão no `appsettings.json` deve ser atualizada com os dados do Azure SQL Server.

