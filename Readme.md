﻿# Cross-platform .NET sample microservices and container based application that runs on Linux Windows and macOS. Powered by .NET 5, Docker Containers. Supports Visual Studio

## Give a Star! :star:

If you like this project, learn something or you are using it in your applications, please give it a star. Thanks!

## Description
todo

## IMPORTANT NOTES!
**You can use either the latest version of Visual Studio or simply Docker CLI and .NET CLI for Windows, Mac and Linux**.

### Internal architecture and design of the microservices
> The microservices are different in type, meaning different internal architecture pattern approaches depending on its purpose, as shown in the image below.

<img  src="https://github.com/mahmudyahyayev/CountwareTrafficContainers/blob/main/img/CountwareContainer_Types_Of_Microservices.PNG?raw=true"></img> 

## CQRS
Read Model - Varies according to microservices
 1. Executing IQueryable queries by  Entity Framework Core (using Entity Framework Core) 
 2.  By running elastic queries (using Nest Elastic)

Write Model - Domain Driven Design approach (using Entity Framework Core).

Commands/Queries/Domain Events handling using Convey library.

## Efcore
todo

## Auto Scale RabbitMQ
RabbitMQ implementation using [Mhd.Framework.RabbitMq](https://github.com/mahmudyahyayev/CountwareTrafficContainers/tree/main/src/BuildingBlocks/Mhd.Framework.RabbitMq)
 >Queues & Exchanges
<img  src="https://github.com/mahmudyahyayev/CountwareTrafficContainers/blob/main/img/CountwareContainer_RabbitMQ_Queues.PNG?raw=true"></img>

<img  src="https://github.com/mahmudyahyayev/CountwareTrafficContainers/blob/main/img/CountwareContainer_RabbitMQ_Exchanges.PNG?raw=true"></img>

## Elastic
todo

## SAGA
Each service has its own database. Data consistency has been preserved using [Choreography-based saga](https://microservices.io/patterns/data/saga.html)


## Outbox Pattern
Outbox Pattern implementation using [Quartz.NET](https://github.com/quartznet/quartznet) | [Mhd.Framework.Scheduler](https://github.com/mahmudyahyayev/CountwareTrafficContainers/tree/main/src/BuildingBlocks/Mhd.Framework.Scheduler)

<img  src="https://github.com/mahmudyahyayev/CountwareTrafficContainers/blob/main/img/CountwareContainer_Outbox_Db_Table.PNG?raw=true"></img> 

## gRPC
todo

## Validation
todo

## Caching
todo

## Related blog articles
todo

## How to run application
todo
