# Personal Assist API

## Integrantes do Grupo
- Cauã Couto Basques (RM97755)
- Kaique Agostinho de Oliveira (RM550815)
- Leonardo Matheus Mariano (RM99824)
- Thiago Gil Camargo (RM551211)
## Estrutura do Repositório

A estrutura do repositório é organizada da seguinte forma:

PersonalAssistAPI/ │ ├── src/ │ ├── PersonalAssistAPI/ │ │ ├── Controllers/ # Controladores da API para gerenciar requisições │ │ │ ├── EmpresasController.cs │ │ │ ├── FeedbacksController.cs │ │ │ ├── ServicosController.cs │ │ │ └── SuportesController.cs │ │ ├── Models/ # Modelos de dados utilizados pela API │ │ │ ├── Empresa.cs │ │ │ ├── Feedback.cs │ │ │ ├── Servico.cs │ │ │ └── Suporte.cs │ │ ├── Services/ # Lógica de negócio da aplicação │ │ │ ├── FeedbackService.cs │ │ │ ├── EmpresaService.cs │ │ │ └── ServicoService.cs │ │ ├── Repositories/ # Implementações do padrão Repository para acesso a dados │ │ │ ├── IFeedbackRepository.cs │ │ │ ├── IEmpresaRepository.cs │ │ │ └── IServicoRepository.cs │ │ ├── Data/ # Migrações e contexto do banco de dados │ │ │ ├── ApplicationDbContext.cs │ │ │ └── Migrations/ │ │ ├── Middleware/ # Classes de middleware personalizadas │ │ ├── Configurations/ # Classes de configuração │ │ ├── ML/ # Implementações de Machine Learning │ │ │ ├── RecommendationModel.cs │ │ │ └── SentimentAnalysisModel.cs │ │ ├── Startup.cs # Configurações da aplicação │ │ └── Program.cs # Ponto de entrada da aplicação │ │ │ ├── PersonalAssistAPI.Tests/ # Contém os testes da API │ │ ├── UnitTests/ # Testes unitários │ │ ├── IntegrationTests/ # Testes de integração │ │ └── SystemTests/ # Testes end-to-end │ │ ├── docs/ # Documentação adicional do projeto │ ├── API_Documentation.md │ ├── Design_Patterns.md │ └── ML_Model_Implementation.md │ ├── data/ # Conjuntos de dados utilizados │ ├── feedbacks.csv │ ├── services.csv │ └── companies.csv │ ├── .gitignore # Arquivo que especifica arquivos a serem ignorados pelo Git ├── README.md # Documentação do projeto ├── LICENSE # Licença do projeto └── appsettings.json
## Arquitetura
- A API é monolítica, facilitando a integração inicial.

## Design Patterns Utilizados
- **Singleton**: Para o gerenciador de configurações.
- **Repository Pattern**: Para abstrair a lógica de acesso a dados.
- **Factory Pattern**: Para a criação de serviços.

## Endpoints
### Empresas
- **GET /api/empresas**: Obtém a lista de todas as empresas.
- **GET /api/empresas/{id}**: Obtém uma empresa específica por ID.
- **POST /api/empresas**: Cria uma nova empresa.
- **PUT /api/empresas/{id}**: Atualiza uma empresa existente.
- **DELETE /api/empresas/{id}**: Remove uma empresa.

### Feedback
- **GET /api/feedbacks**: Obtém a lista de todos os feedbacks.
- **GET /api/feedbacks/{id}**: Obtém um feedback específico por ID.
- **POST /api/feedbacks**: Cria um novo feedback.
- **PUT /api/feedbacks/{id}**: Atualiza um feedback existente.
- **DELETE /api/feedbacks/{id}**: Remove um feedback.

### Serviços
- **GET /api/servicos**: Obtém a lista de todos os serviços.
- **GET /api/servicos/{id}**: Obtém um serviço específico por ID.
- **POST /api/servicos**: Cria um novo serviço.
- **PUT /api/servicos/{id}**: Atualiza um serviço existente.
- **DELETE /api/servicos/{id}**: Remove um serviço.

### Suporte
- **GET /api/suportes**: Obtém a lista de todos os suportes.
- **GET /api/suportes/{id}**: Obtém um suporte específico por ID.
- **POST /api/suportes**: Cria um novo suporte.
- **PUT /api/suportes/{id}**: Atualiza um suporte existente.
- **DELETE /api/suportes/{id}**: Remove um suporte.

## Integração com Serviço Externo
- Implementamos autenticação com JWT através do [serviço escolhido].

## Testes Implementados
- Testes unitários com xUnit.
- Testes de integração para serviços externos.
- Testes de sistema usando Selenium.

## Práticas de Clean Code e SOLID
- Adotamos práticas de Clean Code para garantir legibilidade e manutenção do código.
- Seguindo princípios SOLID, cada classe tem responsabilidades únicas e interfaces segregadas.

## Funcionalidades de IA Generativa
- Implementamos um modelo de recomendação de serviços usando ML.NET.
- Análise de sentimento foi implementada para avaliar feedbacks.

## Como Executar
1. Clone o repositório.
2. Instale as dependências.
3. Configure o banco de dados.
4. Execute as migrações.
5. Execute a aplicação.

Acesse a API em `https://localhost:7130`.
