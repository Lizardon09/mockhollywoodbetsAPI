# mockhollywoodbetsAPI

The MockHollywoodBets API is developed using .NET Core with datasbase interaction using Dapper. The mockhollywoodbets and CRUDmockhollywoodbets sites are built using Angular.

![ERD](https://user-images.githubusercontent.com/57814467/88640746-975c6580-d0be-11ea-8bc0-561fe13e0006.png)

The API solution is divided into 3 projects:

## mockhollywoodbets

Contains controllers utilized by the mockhollywoodbets site to display databse information (including Sports, Countries, Tournaments, etc) and also provide bet striking capabilities for the site.

![mockhollywoodbets](https://user-images.githubusercontent.com/57814467/88643573-27e87500-d0c2-11ea-976e-ef7ab1f0b23d.PNG)

## CRUDMockHollywoodBets

Contains controllers utilized by the CRUDmockhollywoodbets site to enable Creation, Update, and Delete functionality for database entries retrieved by the mockhollywoodbets site through the API.

![CRUDmockhollywoodbets](https://user-images.githubusercontent.com/57814467/88645888-eb6a4880-d0c4-11ea-9fae-175741297202.PNG)

## MockHollywoodBetsDAL



