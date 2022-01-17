# How to try CosmosDB implementation

The project already contains all the necessary code for working with CosmosDB. However, you need the database itself to work correctly.

## Create CosmosDB
The first step is to create an **Azure Cosmos DB Account** (or use existing). When choosing database API, you should select **Core (SQL)** API. This is important.

## Import data
Use the **Azure DocumentDB Data Migration Tool** to import data. You can download it [here](https://www.microsoft.com/en-us/download/details.aspx?id=46436).

1. Run the **Azure DocumentDB Data Migration Tool**.
2. Click "Next".
3. Choose "**JSON file(s)**" in "**Import from**" dropdown.
4. Add **datasets.json** file (in "**To import**" folder)
5. Click "Next".
6. Paste **Connection String** like `AccountEndpoint=[your_endpoint];AccountKey=[your_key];Database=[your_db_name]` (*you can find your account endpoint and key in **Settings->Keys** section of your CosmosDB account. Database name choose like you want*).
7. Insert your file name (without extension) in **Collection** filed (e.g. for **datasets.json** it will be **datasets**).
8. **Partition Key** set to **/id**.
9. **Id field** set to **id**.
10. Click "Next".
11. Click "Next".
12. Click "Import".
13. Click "New import" and repeat steps 4-12 for other files (*images, reports, templates, themes, tmp*).

## Set connection
Once the database has been created and populated with the required content, you need to set up the application's connection to the database.

1. In **App.config** insert your account endpoint and key.
2. In **Startup.cs** comment line with the registration of the LiteDB implementation (*line #37*).
3. In **Startup.cs** uncomment line with the registration of the CosmosDB implementation (*line #38*).
4. In **CosmoDB.cs** change **DATABASE_NAME** to required name.

After completing all the above steps, the sample should build and run without any problems. 