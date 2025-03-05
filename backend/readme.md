**ÍNDICE**
[[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#1. Introdução|1. Introdução]]
[[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#2. Arquitetura do Sistema|2. Arquitetura do Sistema]]
[[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#3. Endpoints|3. Endpoints]]
- [[#3.1 Funcionarios]]
- [[#3.2 EstoqueInsumo]]
- [[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#3.3 EstoqueProduto|3.3 EstoqueProduto]]
- [[#3.4 EntradaInsumo]]
- [[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#3.5 SaidaProduto|3.5 SaidaProduto]]
- [[#3.6 SaidaInsumo]]
- [[#3.7 Maquinas]]
- [[#3.8 OrdemPedido]]
---
---
# 1. Introdução
O documento descreve a estrutura, funcionamento e padronização no backend para o sistema ERP(MRP-I | MRP-II), auxiliando o gerenciamento e produção para uma indústria têxtil, focada em vestimentas.

---
# 2. Arquitetura do Sistema
O backend irá utilizar a linguagem de programação **C# .NET** com uma abordagem **RestFul** para endpoints. Haverá **controllers distintas** entre MRP's, onde terá uma comunicação direta entre as mesmas.

**Informações estruturais**
- **Variáveis:** camelCase
- **Classes e Métodos:** PascalCase
- **Servidor:** Externo
- **Local de teste:** Swagger

---
# 3. Endpoints
## 3.1 Funcionarios
```
GET https://localhost:porta/api/MRP1/Operadores
POST https://localhost:porta/api/MRP1/Operadores

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Matricula" : "String",
	"Maquina" : 0,
	"Cargo" : "String",
	"Hierarquia" : 0,
	"Setor" : "String",
	"Senha" : "String",
	"Status" : 0
```
## 3.2 EstoqueInsumo
```
GET https://localhost:porta/api/MRP1/EstoqueMaterial
POST https://localhost:porta/api/MRP1/Operadores

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Tipo" : "String",
	"Codigo" : "String",
	"Fornecedor" : "String",
	"Qntd" : "String"
```
## 3.3 EstoqueProduto
```
GET https://localhost:porta/api/MRP1/EstoqueProduto
GET{id} https://localhost:porta/api/MRP1/EstoqueProduto/{id}

POST https://localhost:porta/api/MRP1/EstoqueProduto

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Tipo": "String",
	"Codigo" : "String",
	"Operador" : 0,
	"Maquina" : 0,
	"Qntd" : 0
```

## 3.4 EntradaInsumo
```
GET https://localhost:porta/api/MRP1/LogEntrada
POST https://localhost:porta/api/MRP1/LogEntrada

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Tipo" : "String",
	"Codigo" : "String",
	"Transportadora" : "String",
	"Fornecedor" : "String",
	"DataEntrada" : data
```

## 3.5 SaidaProduto
```
GET https://localhost:porta/api/MRP1/LogSaida
POST https://localhost:porta/api/MRP1/LogSaida

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Tipo" : "String",
	"Codigo" : "String",
	"Transportadora" : "String",
	"DataSaida" : data

```

### 3.6 SaidaInsumo
```
GET https://localhost:porta/api/MRP1/LogSaida
POST https://localhost:porta/api/MRP1/LogSaida

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Tipo" : "String",
	"Codigo" : "String",
	"Transportadora" : "String",
	"Setor" : "String",
	"DataSaida" : data
	
```
### 3.7 Maquinas
~~~~
GET https://localhost:porta/api/MRP2/Maquinas
POST https://localhost:porta/api/MRP2/Maquinas

	"ID" : 0, // POST: Gerado pelo BD
	"Maquina" : "String",
	"Modelo" : "String",
	"Status" : "String",
	"Operador" : "String",
	"SerialNumber" : "String"
~~~~

## 3.8 OrdemPedido
```
	TO DO :]
```
