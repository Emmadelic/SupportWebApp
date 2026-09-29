# Afleveringsopgave – Emma Delic

## Formålet med SupportWebApp:

SupportWebApp er en Blazorapp til at oprette og vise supporthenvendelser. Brugeren kan indtaste kontaktoplysninger, vælge en kategori og beskrive sit problem. 
Henvendelserne gemmes i Azure Cosmos DB og vises på en oversigtsside.

## Oprettelse af Cosmos DB:

Azure ressourcerne oprettes fra Bash med Azure CLI. Først logger man ind med az login og vælger abonnement med az account set.  
Derefter oprettes en resource group med az group create og en Cosmos DB-konto med az cosmosdb create. 
Databasen oprettes med az cosmosdb sql database create, og containeren med az cosmosdb sql container create. 
Containeren bruger /category som partition key, så den passer til appens kategorifelt. 
Appens connection string, database og containernavn opbevares lokalt i User Secrets.

### Jeg brugte disse kommandoer til user secrets:

- dotnet user-secrets set "CosmosDb:ConnectionString" "CONNECTION_STRING"
- dotnet user-secrets set "CosmosDb:DatabaseName" "IBasSupportDB"
- dotnet user-secrets set "CosmosDb:ContainerName" "ibassupport"
- dotnet run 

## Status:

Appen kan oprette supporthenvendelser og hente dem fra Cosmos DB. 
Jeg har afprøvet, at nye henvendelser bliver gemt og vist. Formularen validerer input. 
Næste trin kunne være at slette og redigere henvendelser.
