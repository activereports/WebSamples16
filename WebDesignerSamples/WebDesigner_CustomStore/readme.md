# Web Designer ASP.NET Core sample

This sample demonstrates the use of custom resources service for GrapeCity ActiveReports Web Designer with an ASP.NET Core backend.

To use custom store for a designer follow these steps:
1.  Implement `IResourcesService` interface. Also you should implement `IDisposable` interface if you use any unmanaged resources.
2. Implement `ResourceLocator` for your store. It is required for the correct getting report resources (datasets, themes, images, etc).
3. In `GetReport` method redefine report site using implemented resourse locator. See `CustomStoreReports.cs` for more details.
4. In `Startup` class:
   1. Register your implemented `IResourcesService` service.
   2. Call `UseCustomStore` method for viewer (`app.UseReporting`) with `GetReport` method as argument.
   3. Call `UseCustomStore` method for designer (`app.UseDesigner`) with `IResourcesService` implementation as argument.

This case contains two different implementations based on the [LiteDB](https://www.litedb.org/) and [CosmosDB](https://azure.microsoft.com/en-us/services/cosmos-db/) as an example.

LiteDB implementation is used by default. To try CosmosDB implementation, please, follow [this guide](resources/CosmosDB/howto.md).

## System requirements

This sample requires:
* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) 17.0 or newer
* [.NET 6.0 SDK](https://www.microsoft.com/net/download)
* [.NET Core Hosting Bundle](https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-aspnetcore-6.0.0-windows-hosting-bundle-installer) (for deployment to IIS)

## Build the sample

1. Start Microsoft Visual Studio and select **File → Open →
   Project/Solution**.
2. Go to the sample folder. Double-click the Visual Studio Solution (.sln)
   file.
3. Right-click the solution in Solution Explorer and select **Restore NuGet
   Packages**.
4. Press Ctrl+Shift+B, or select **Build → Build Solution**.

## Run the sample

To debug the sample and then run it, press F5 or select **Debug → Start
Debugging**. To run the sample without debugging, press Ctrl+F5 or select
**Debug → Start Without Debugging**.
