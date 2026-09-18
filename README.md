# ♻️ Reciclagem Que Paga — MVP Terminal Kiosk

> **Sistema Desktop de incentivo à reciclagem com cálculo de recompensas em tempo real e gestão de saldo.**

O **Reciclagem Que Paga** é um projeto de MVP (Minimum Viable Product) desenvolvido no curso de Programador de Sistemas do **SENAC Vila Prudente**. O sistema simula um terminal de autoatendimento (Kiosk) onde usuários realizam a entrega de materiais recicláveis (PET, Alumínio, Papelão, Vidro), recebem estimativas de recompensa com base no peso e acumulam saldo diretamente em suas contas de forma automatizada.

---

## 🛠️ Tech Stack & Ferramentas

* **Linguagem:** C# (.NET 8)
* **Interface:** Windows Forms (UI modularizada com padrão Kiosk/Cards)
* **Persistência & ORM:** Entity Framework Core + SQL Server
* **Qualidade & Testes:** xUnit
* **Controle de Versão:** Git / GitHub (Workflow baseado em Feature Branches e Code Review via Pull Requests)

---

## 🏗️ Arquitetura do Sistema

A aplicação foi estruturada seguindo o padrão de **Separação de Responsabilidades em Camadas** para isolar a regra de negócio da interface gráfica:

```text
[ Windows Forms ] ──> [ Services ] ──> [ Repositories ] ──> [ DbContext / SQL Server ]
  (UI / Views)         (Business)       (Data Access)           (Entity Framework)
