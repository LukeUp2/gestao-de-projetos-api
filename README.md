## 🧠 Desafio Técnico – Sistema de Gestão de Projetos e Demandas

### 📘 Contexto

Sua missão é desenvolver uma **API RESTful em Java com Spring Boot** para gerenciar **projetos e tarefas (demandas)** de uma empresa.  
O sistema será utilizado por um time de desenvolvimento para organizar suas entregas, acompanhar o status das tarefas e realizar análises simples.

---

## 🎯 Requisitos Técnicos

### 🧱 1. Modelagem de Domínio

A modelagem pode ser modificada pelo inscrito. Porém, precisa ser justificado o motivo.

#### `Project`

| Campo         | Tipo           | Descrição         |
| ------------- | -------------- | ----------------- |
| `id`          | UUID/Long      | Identificador     |
| `name`        | String (3–100) | **Obrigatório**   |
| `description` | String         | Opcional          |
| `startDate`   | Date           | Início do projeto |
| `endDate`     | Date           | Opcional          |

#### `Task`

| Campo         | Tipo           | Descrição           |
| ------------- | -------------- | ------------------- |
| `id`          | UUID/Long      | Identificador       |
| `title`       | String (5–150) | **Obrigatório**     |
| `description` | String         | Detalhes da tarefa  |
| `status`      | Enum           | TODO / DOING / DONE |
| `priority`    | Enum           | LOW / MEDIUM / HIGH |
| `dueDate`     | Date           | Data limite         |
| `projectId`   | FK(Project)    | Relacionamento      |

---

### 🌐 2. Endpoints REST

| Método     | Endpoint                              | Descrição                                     |
| ---------- | ------------------------------------- | --------------------------------------------- | --- |
| **POST**   | `/projects`                           | Criar novo projeto (`name` obrigatório)       | ✅  |
| **GET**    | `/projects`                           | Listar todos os projetos (paginação opcional) | ✅  |
| **POST**   | `/tasks`                              | Criar nova tarefa vinculada a um projeto      | ✅  |
| **GET**    | `/tasks?status=&priority=&projectId=` | Buscar tarefas com filtros opcionais          | ✅  |
| **PUT**    | `/tasks/{id}/status`                  | Atualizar apenas o status da tarefa           | ✅  |
| **DELETE** | `/tasks/{id}`                         | Remover tarefa                                | ✅  |

---

## 🏅 Diferenciais (Pontos Extras)

- 🧭 Documentação **Swagger / OpenAPI**
- 🔐 Autenticação simples com **JWT** ou Basic Auth
- 🐳 Configuração de **Docker** / **docker-compose** ✅
- ⚡ Uso de **MapStruct** para mapeamento de DTOs
- 🔍 Testes de API com **RestAssured**

---

### 💡 Dica

> Foque em **organização, boas práticas e clareza do código**.  
> Um bom README e commits bem descritos também serão avaliados. 😉

---

### 🧾 Licença

Este projeto foi desenvolvido exclusivamente para o **processo seletivo SIS Innov & Tech** e não deve ser utilizado para fins comerciais.

---
