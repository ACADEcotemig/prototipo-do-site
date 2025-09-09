# Nome do Projeto:
ACADE

## Descrição
Um site sobre coleta de lixo inteligente, onde buscamos na sua casa, o seu lixo que você não sabe corretamente onde depositar

## Integrantes
- Ana Julia Ribeiro Lopes - 12302686
- Arthur Babetto Severino - 12401676
- Caetano Drumond Dutra Gomes - 12302872
- Davi Fernando Aniceto Nunes - 22402683
- Enduardo Henrique Ribeiro - 22402667

## Estrutura de Diretório
```text
prototipo-do-site-main
├── .gitignore
│   └── .vs
│       ├── AcadeAppSolution
│       │   ├── DesignTimeBuild
│       │   │   └── .dtbcache.v2
│       │   ├── FileContentIndex
│       │   │   └── 2fcd3d28-d3a6-48f7-9dd9-49938c5921eb.vsidx
│       │   ├── config
│       │   │   └── applicationhost.config
│       │   └── v17
│       │       ├── .futdcache.v2
│       │       ├── .suo
│       │       ├── DocumentLayout.backup.json
│       │       └── DocumentLayout.json
│       └── ProjectEvaluation
│           ├── acadeappsolution.metadata.v9.bin
│           ├── acadeappsolution.projects.v9.bin
│           └── acadeappsolution.strings.v9.bin
├── AcadeAppApi
│   ├── .vs
│   │   ├── AcadeAppApi
│   │   │   ├── CopilotIndices
│   │   │   │   └── 17.14.1091.29919
│   │   │   │       ├── CodeChunks.db
│   │   │   │       └── SemanticSymbols.db
│   │   │   ├── FileContentIndex
│   │   │   │   ├── 11cf4086-839f-48a5-9d08-c8810d850858.vsidx
│   │   │   │   ├── 1c922333-47e0-4c6c-b573-b67a69221843.vsidx
│   │   │   │   ├── 57744ce2-0778-4b99-82f1-8aec3fe225d8.vsidx
│   │   │   │   ├── e42b8648-8598-4512-839d-45321f89d03e.vsidx
│   │   │   │   └── e4bd3f0e-253f-462b-a1b3-1fba56c20c0c.vsidx
│   │   │   └── v17
│   │   │       ├── .wsuo
│   │   │       ├── DocumentLayout.backup.json
│   │   │       └── DocumentLayout.json
```
## Como Executar o Projeto

### 1. Pré-requisitos
- **.NET 7.0 SDK** ou superior  
- **Visual Studio 2022** (ou outra IDE compatível com .NET)  
- **SQL Server (LocalDB ou Express)** para rodar as migrações do Entity Framework  
- **Git** para clonar o repositório  

### 2. Instalação
bash
# Clone o repositório
git clone https://github.com/usuario/repositorio.git
# Acesse a pasta do projeto
cd prototipo-do-site-main
# Como Executar o Projeto
- Executar o AcadeAppApi (para o banco de dados)
- Executar o AcadeAppWeb (para o site)
- para ver todos os usuarios, visite http://localhost:5004/usuarios
- para cadastrar usuarios, use a aba "Cadastro"

### 3. Execução
# Acesse a pasta da API e execute
cd AcadeAppApi
dotnet run
# Em outro terminal, acesse a pasta do frontend (Blazor) e execute
cd AcadeAppWeb/AcadeAppWeb
dotnet run

### 4. Acesso
```text
#API Backend: http://localhost:5000
#Frontend (Blazor WebApp): http://localhost:5001
#Banco de Dados: configurado em AcadeAppApi/appsettings.json
#Usuário padrão: (defina aqui caso exista)
#Senha padrão: (defina aqui caso exista)
```
## Funcionalidades

- [ ] Cadastro de usuários  
- [ ] Redefinição de senha  
- [ ] Notificações de lembretes  
- [ ] Visualização do histórico de atividades  
- [ ] Integração com redes sociais  
- [ ] Personalização da interface  
- [ ] Dashboard com métricas de uso  
- [ ] Sistema de suporte a múltiplos idiomas  
- [ ] Exportação de relatórios em PDF  
- [ ] Sistema de busca de lugares para jogar o lixo eficiente  
- [ ] Registro da localização do usuário  
- [ ] Localização dos pontos de coleta na região  
- [ ] Agenda de coleta de lixo  
- [ ] Acompanhamento da quantidade de lixo recolhido  
- [ ] Mecanismo de avaliação do serviço de coleta  
- [ ] Consulta de horários de coleta por bairro  
- [ ] Opção de agendamento de coletas especiais  
- [ ] Educação Ambiental e Dicas  
- [ ] Solicitação de Coleta Especial Urgente  
- [ ] Relatório de Impacto Ambiental Pessoal 

# Projeto
- [x] Protótipo visual do site com aimações usando o figma
- [x] html/css do projeto
- [x] Migrar de HTML/CSS para Blazor
- [ ] Parte funcional (utilizando blazor);
