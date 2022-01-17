# Batch print ASP.NET Core sample

This sample demonstrates how we can  print many different reports by clicking once the print button 
without showing the print preview dialog for every report.
Silent printing is implemented through a print agent that needs to be started.

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

## Run print agent
To run print agent in console mode do next:
1. Go to the print agent sample folder.
2. Run the print agent in console mode using the following command line: **dotnet run --console**.

For install print agent as Windows service, see print agent readme.md.

## Run the sample

To debug the sample and then run it, press F5 or select **Debug → Start
Debugging**. To run the sample without debugging, press Ctrl+F5 or select
**Debug → Start Without Debugging**.

## Report list

To add a new report to report list do next:
1. Copy report file to **"..\..\JsViewerReports"** folder
2. Specify report name, report parameter, parameter values, export settings in **"wwwroot\report.json"** file.
