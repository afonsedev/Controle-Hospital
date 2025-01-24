
# Gerenciador Hospitalar - GH

Projeto Windows Forms desenvolvido para ambiente hospitalar com rotina de agendamento de consultas.

![Demonstração](Gravação-de-tela-1-_online-video-cutter.com_.gif)

- O programa inicia com uma tela de autenticação para garantia de segurança;

- Após o login autorizado, o usuário vai para a tela inicial, com informações requisitadas no banco sobre seu nome e setor;

- O colaborador pode fazer operações CRUD sobre agendamento de exames para pacientes cadastrados, com validação de erros para campos específicos e essenciais.

- Ao desejar sair do app, ele tem uma tela de confirmação caso tenha pressionado o botão de fechar acidentalmente

## Arquitetura de Nuvem Azure
<img src="Diagrama_Hospital_Atualizado.drawio.svg">

-  Utilizando como base a topologia de rede Hub-Spoke, as requisições externas e envio de informações da nuvem para a Internet são centralizadas na Vnet Hub, que conta com balanceadores de carga no nível da rede, application gateway para comunicação com a Internet, e um Web Firewall para prevenção de DDOS.

- Cada recurso agora é inserido dentro de um spoke, que vai isolar e garantir funcionamento independente de outras redes virtuais, evitando complexidade ao remover ou inserir novos serviços.

- O Internal Load Balancer vai direcionar para o spoke do banco de dados primário, que faz um peering com a VNET Hub. Em caso de falha, o mesmo processo acontece com o spoke do banco de replicação.

- Cada spoke conta com um SQL Server e um Cache for Redis, esse último é implantado para dados frequentemente acessados, evitando failover no banco.

- Cost Management para insights sobre custos.

- Azure Monitor para verificação de integridade dos recursos.




## Como utilizar o app?

 - Clonando este repositório (terminal)
  > 🌟 **git clone https://github.com/afonsedev/Controle-Hospital.git**  
 - [Download do software (abra o setup e concorde com os termos do .NET, após a instalação, abra o arquivo do tipo application manifest na mesma pasta, ou pesquise na Aba Iniciar do Windows)](https://drive.google.com/drive/folders/1Q_ZbrUUaiHhqkPqyaKPh_l3c5NbYzAXO?usp=sharing)
 - [Base de dados dos pacientes, exames,  usuários e salas para testar o software:](https://docs.google.com/spreadsheets/d/1LNnkhQDvv5cafETPO4hO5ZzHu7yJCiW1X9N8TcZkUb4/edit?usp=sharing)


## Documentação

[Documentação do software](https://docs.google.com/document/d/1sPnjcye6g805wpANJ3SLGQxcJtGvD8yqkzFWcDtZIdY/edit?tab=t.0)


## Funcionalidades

- Adicionar agendamento
- Consultar agendamento
- Consultar agendamento
- Apagar agendamento
- Gerar QR Code com os dados do agendamento


## Stacks
- Linguagens: <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" width="30" height="30"/> <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/azuresqldatabase/azuresqldatabase-original.svg" width="30" height="30"/> 
- Framework:  <img loading="lazy" src="https://dotnet.microsoft.com/blob-assets/images/dotnet-icons/square.png" width="30" height="30"/>
- Cloud: <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/azure/azure-original.svg" width="30" height="30"/>
- Migração de banco de dados: Microsoft Data Migration Assistant
