**ÍNDICE**
[[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#1. Introdução|1. Introdução]]
[[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#2. Arquitetura do Sistema|2. Arquitetura do Sistema]]
[[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#3. Endpoints|3. Endpoints]]
- [[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#3.1 Operadores|3.1 Operadores]]
- [[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#3.2 EstoqueMaterial|3.2 EstoqueMaterial]]
- [[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#3.3 EstoqueProduto|3.3 EstoqueProduto]]
- [[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#3.4 EntradaMaterial|3.4 EntradaMaterial]]
- [[DOCUMENTAÇÃO - API ERP(MRP-I, MRP-II)#3.5 SaidaProduto|3.5 SaidaProduto]]

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
## 3.1 Operadores
```
GET https://localhost:porta/api/MRP2/Operadores
POST https://localhost:porta/api/MRP2/Operadores

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Maquina" : 0,
	"Setor" : "String"
```
## 3.2 EstoqueMaterial
```
GET https://localhost:porta/api/MRP2/EstoqueMaterial
POST https://localhost:porta/api/MRP2/Operadores

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Tipo" : "String",
	"Codigo" : "String",
	"DataEntrada" : data,
	"DataSaida" : data
```
## 3.3 EstoqueProduto
```
GET https://localhost:porta/api/MRP2/EstoqueProduto
GET{id} https://localhost:porta/api/MRP2/EstoqueProduto/{id}

POST https://localhost:porta/api/MRP2/EstoqueProduto

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Tipo": "String",
	"Codigo" : "String",
	"Operador" : 0,
	"Maquina" : 0,
```

## 3.4 EntradaMaterial
```
GET https://localhost:porta/api/MRP2/LogEntrada

POST https://localhost:porta/api/MRP2/LogEntrada

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Tipo" : "String",
	"Codigo" : "String",
	"Transportadora" : "String",
	"DataEntrada" : data
```

## 3.5 SaidaProduto
```
GET https://localhost:porta/api/MRP2/LogSaida

POST https://localhost:porta/api/MRP2/LogSaida

	"ID" : 0, // POST: Gerado pelo BD
	"Nome" : "String",
	"Tipo" : "String",
	"Codigo" : "String",
	"Transportadora" : "String",
	"DataSaida" : data

```

## 3.6 OrdemPedido
```
	TO DO :]
```

