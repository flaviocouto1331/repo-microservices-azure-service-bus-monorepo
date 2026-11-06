# 🚀 Microservices Azure Service Bus Monorepo

1. Microservices Azure Service Bus

Sistema de processamento de pedidos orientado a eventos (EDA) estruturado em **Monorepo** .NET, utilizando **Azure Service Bus** para mensageria, **Azure Functions** para processamento assíncrono de filas e APIs RESTful.

---

2. Estrutura da Solução

Conforme a solução `repo-microservices-azure-service-bus-monorepo`:

```text
├── 📁 docker/               # Configurações de containers da solução
├── 📁 sql/                  # Scripts e migrações de banco de dados
├── 🌐 api_cartao            # API para validação/gestão de cartões
├── 🌐 api_cliente           # API de gestão de clientes
├── 🌐 api_pedido            # API para criação e consulta de pedidos
├── 🌐 api_produto           # API de controle de produtos e catálogo
├── ⚡ fn_estoque_queue      # Azure Function (Service Bus Trigger): Checagem e reserva de estoque
└── ⚡ fn_pagamento_queue    # Azure Function (Service Bus Trigger): Processamento de pagamento

3. Tutorial

Passo 1: Clonar o projeto para sua máquina local.
Passo 2: Executar o docker compose referente na pasta do projeto /docker/docker-compose-azure-service-bus.yml.
Passo 3: Utilizando uma ferramenta de gerenciamento e visualização de banco de dados, executar o script da pasta do projeto /sql/scripts.sql.
Passo 4: No navegador utilize a seguinte URL do Swagger:
http://localhost:1003/swagger/index.html
Passo 6: Siga o procedimento abaixo.

Procedimento de Teste
Execute o endpoint POST /api/pedidos

Payload de Requisição:

{
  "idCliente": "[idCliente]",
  "nomeCliente": "Flávio Couto",
  "cartaoCliente": "CARD-29550C89-7587-4177-AB4C-0128F2830CA9",
  "idProduto": "[idProduto]",
  "nomeProduto": "Nintendo Switch 2"
}

Um pedido será criado com StatusPedido > PEDIDO_PROCESSADO

O mesmo será enviado para fila do Azure Service Bus
  fila-estoque   PEDIDO_CANCELADO_FALTA_ESTOQUE ou PEDIDO_AGUARDANDO_PAGAMENTO envia para próxima fila
  fila-pagamento PEDIDO_CANCELADO_CARTAO_RECUSADO ou PEDIDO_AGUARDANDO_ENVIO 
