# 🚀 Microservices Azure Service Bus Monorepo

Sistema de processamento de pedidos orientado a eventos (EDA) estruturado em **Monorepo** .NET, utilizando **Azure Service Bus** para mensageria, **Azure Functions** para processamento assíncrono de filas e APIs RESTful.

---

## 🏗️ Estrutura da Solução

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
