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

Contains the DAL (Data Access Layer) built using a repository pattern, that is referenced by the other two projects, which manages the interactions with the databse and channels the data between the API and the databse. The project containes 3 sub-folders:

Models - Contains the classes and dbcontext for the data within the databse

CustomModels - contains viewmodels for combined/custom data from the databse

DataMangers - contains interfaces of repositories with their implimentations that provide the functional interactions with the databse for the API.

![DAL](https://user-images.githubusercontent.com/57814467/88646602-882ce600-d0c5-11ea-9096-2d8cacbe3715.PNG)
