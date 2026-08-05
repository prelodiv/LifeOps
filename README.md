# LifeOps

**AI-powered personal operating system for health, habits, finances, planning, and career growth.**

> Project reset: August 4, 2026  
> Current status: Phase 0 — Architecture and foundations

LifeOps is a personal product and a practical software-engineering laboratory. Its purpose is to centralize personal information and turn it into useful context for daily decisions.

The project has two equally important goals:

1. Build an application that is genuinely useful in everyday life.
2. Build a portfolio project that demonstrates understood, explainable engineering decisions.

## Core principle

LifeOps must not become a collection of technologies added only to fill a résumé.

Every technology must solve a concrete problem, and its purpose, alternatives, trade-offs, and consequences must be explainable.

> If the developer cannot explain a part of LifeOps during an interview, that part is not finished.

## Learning workflow

For every new concept or important implementation:

1. Define the problem.
2. Explain the concept.
3. Compare alternatives.
4. Evaluate advantages and disadvantages.
5. Choose an alternative.
6. Justify the decision.
7. Define requirements.
8. Implement it personally.
9. Review the implementation.
10. Correct and document what was learned.

AI acts primarily as a mentor, architecture consultant, reviewer, teacher, debugger, and technical interviewer. It does not generate complete features by default.

## Product vision

LifeOps will combine information from several personal areas:

- Identity and profile
- Habits and goals
- Health, weight, and nutrition
- Career development and job applications
- Debts and personal finances
- Daily planning and priorities
- AI-assisted queries and recommendations
- A central Today dashboard

The long-term assistant should be able to answer questions such as:

> What should I focus on today?

using real information from the user's agenda, habits, nutrition, health progress, studies, job applications, debts, and goals.

## Target architecture

The intended architecture is:

**Pragmatic Microservices + Hexagonal Architecture + Event-Driven Communication**

The initial backend boundaries are intentionally limited to four services:

```text
Clients
├── Next.js Web/PWA
└── React Native with Expo
        │
        ▼
    YARP API Gateway
        │
        ├── Identity Service ── IdentityDb
        ├── Core Service ────── CoreDb
        ├── Health Service ──── HealthDb
        └── AI Orchestrator ─── AiDb ── OpenAI API
```

Core initially groups the smaller domains:

```text
Habits
Goals
Planning
Finance
Career
```

Health owns weight, measurements, nutrition, food, meals, macros, and future health integrations.

Each service owns its data. No service may query another service's database directly; communication must happen through APIs, events, or purpose-built projections.

## Planned technology stack

These technologies are targets, not claims about the current implementation:

- C# and ASP.NET Core
- Entity Framework Core and SQL Server
- Next.js, React, and TypeScript
- React Native and Expo
- YARP API Gateway
- RabbitMQ for local messaging
- Docker and Docker Compose
- Azure Container Apps and Azure SQL
- GitHub Actions
- OpenTelemetry
- OpenAI API with tool calling

## Progressive roadmap

Dates are guides. A phase ends when its learning and product outcomes are demonstrated, not merely when a date arrives.

### Phase 0 — Architecture audit and decisions

- Reset and understand the repository
- Establish the new project baseline
- Create a system context diagram
- Define initial service boundaries
- Write ADR-001: Why Microservices for LifeOps
- Write ADR-002: Initial Service Boundaries

### Phase 1 — Backend fundamentals

- Identity Service
- Core Service
- REST, DTOs, validation, dependency injection, EF Core, SQL, JWT, and refresh tokens
- No Gateway, messaging, or AI yet

### Phase 2 — Hexagonal architecture

- Understand domain, application, ports, adapters, and dependency inversion
- Refactor one service consciously
- Apply the learned pattern to the second service

### Phase 3 — Health

- Health Service and HealthDb
- Weight, goal weight, and weight history
- Nutrition later, including an external provider adapter

### Phase 4 — API Gateway

- Introduce YARP after direct client-to-service communication is understood
- Learn routing, token propagation, headers, correlation, and rate-limiting concepts

### Phase 5 — Web application

- Next.js, React, and TypeScript
- Login, Today, Habits, Weight, and Nutrition
- Prioritize end-to-end functionality over visual perfection

### Phase 6 — Core expansion

- Career
- Finance and debts
- Planning

### Phase 7 — Docker

- Images, containers, networking, volumes, and environment variables
- Containerize the existing services
- Add Docker Compose only after the individual containers are understood

### Phase 8 — Messaging

- Introduce RabbitMQ for one or two real use cases
- Learn producers, consumers, exchanges, acknowledgements, retries, dead-letter queues, and idempotency

### Phase 9 — Distributed-system failures

- Reproduce duplicate messages, unavailable services, slow requests, and processing failures
- Introduce timeouts, retries, idempotent consumers, and eventual consistency where justified

### Phase 10 — AI Orchestrator

- Structured output and tool calling
- Prompt-injection defenses, permissions, rate limits, and cost awareness
- Read-only tools first; write operations only after explicit safeguards

### Phase 11 — Mobile

- React Native with Expo
- Android first
- Login, Today, Habits, quick nutrition logging, and AI chat

### Phase 12 — Cloud and CI/CD

- Deploy manually before automating
- Azure SQL, Azure Container Apps, Vercel, and GitHub Actions

### Phase 13 — Observability

- Structured logging, health checks, and correlation IDs
- OpenTelemetry and distributed tracing

### Phase 14 — Portfolio polish

- Professional documentation
- Architecture and sequence diagrams
- ADRs and technical challenges
- Screenshots, demonstration video, and future roadmap

## Anti-overengineering rule

Before introducing any technology, answer:

1. What current problem exists?
2. Why does this technology solve it?
3. What simpler alternative exists?
4. What cost or complexity does it introduce?
5. Can the decision be explained clearly?

If there is no clear answer, the technology stays in the backlog.

## Not part of the initial MVP

- Kubernetes or AKS
- Kafka
- Event sourcing
- Full CQRS
- Service mesh
- GraphQL
- Redis
- gRPC
- Vector databases
- Temporal or Dapr
- Elasticsearch
- Multiple cloud providers
- A separate repository per microservice

## Definition of done for a feature

A feature is complete only when it:

- works end to end;
- has basic error handling;
- is tested appropriately;
- respects service and domain boundaries;
- is understood by the developer;
- has explainable technical decisions;
- does not introduce an unjustified architectural dependency.

## Current repository state

The previous experimental API and models were intentionally removed. The repository currently contains no application implementation.

The next deliverables are architectural understanding, ADR-001, and ADR-002. New services will be created only after their purpose and boundaries can be explained.

## Master project plan

The complete LifeOps Master Project Plan v2 is available in both formats:

- [Word document](docs/LifeOps%20Master%20Project%20Plan%20v2.docx)
- [PDF document](docs/LifeOps%20Master%20Project%20Plan%20v2.pdf)

## North star

The goal is not to build the most complex architecture possible. The goal is to design, implement, test, deploy, and confidently explain a useful distributed full-stack system—one justified decision at a time.
