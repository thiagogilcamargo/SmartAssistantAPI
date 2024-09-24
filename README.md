# Personal Assist API

## Integrantes do Grupo
- Cauã Couto Basques (RM97755)
- Kaique Agostinho de Oliveira (RM550815)
- Leonardo Matheus Mariano (RM99824)
- Thiago Gil Camargo (RM551211)

## Arquitetura
- A API é monolítica, facilitando a integração inicial.

## Design Patterns Utilizados
- **Singleton**: Para o gerenciador de configurações.
- **Repository Pattern**: Para abstrair a lógica de acesso a dados.
- **Factory Pattern**: Para a criação de serviços.

## Endpoints
- **Empresas**: CRUD para empresas.
- **Feedback**: CRUD para feedbacks.
- **Serviços**: CRUD para serviços.
- **Suporte**: CRUD para suporte.

## Instruções para Rodar a API
1. Clone o repositório.
2. Instale as dependências.
3. Configure o banco de dados.
4. Execute as migrações.
5. Execute a aplicação.

## Testes Implementados
- Testes unitários com xUnit.
- Testes de integração para serviços externos.
- Testes de sistema usando Selenium.

## Práticas de Clean Code e SOLID
- Adotamos práticas de Clean Code para garantir legibilidade e manutenção do código.
- Seguindo princípios SOLID, cada classe tem responsabilidades únicas e interfaces segregadas.

## Funcionalidades de IA Generativa
- Implementamos recomendações de serviços usando ML.NET.
- Análise de sentimento foi implementada para avaliar feedbacks.

## Como Executar
- Acesse a API em `https://localhost:7130`.
