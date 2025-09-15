🧱 Minimal API (.NET 9)

Este projeto é uma API minimalista desenvolvida com .NET 9, utilizando os recursos mais recentes da plataforma para criar uma estrutura enxuta, eficiente e escalável.

🚀 Objetivo
Demonstrar como construir uma API RESTful utilizando o modelo de Minimal APIs do .NET, com separação de responsabilidades em camadas como Domínio e Infraestrutura, além de boas práticas de configuração e organização.

📁 Estrutura do Projeto
minimal-api/
├── Dominio/               # Entidades e interfaces de negócio
├── Infraestrutura/        # Implementações de repositórios e serviços
├── Properties/            # Configurações do projeto
├── Program.cs             # Ponto de entrada da aplicação
├── appsettings.json       # Configurações gerais
├── appsettings.Development.json
├── minimalapi.csproj      # Arquivo de projeto
└── minimalapi.sln         # Solução do projeto


🛠️ Tecnologias Utilizadas
- .NET 9
- C#
- Minimal APIs
- Injeção de Dependência
- Configuração via appsettings.json
📦 Como Executar
- Clone o repositório:
git clone https://github.com/Raphael2203/minimal-api.git
cd minimal-api

- Restaure os pacotes e execute:
dotnet restore
dotnet run

- A API estará disponível em https://localhost:5001 (ou conforme configurado).
📌 Próximos Passos
- Adicionar testes unitários
- Documentação com Swagger
- Autenticação e autorização
- Deploy em ambiente cloud