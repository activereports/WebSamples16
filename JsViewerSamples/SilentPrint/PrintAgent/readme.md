# Print agent ASP.NET Core sample

This print agent sample contains a Windows service, hosting an ASP.NET Core API that lets us print PDF files. 
Print agent uses the GrapeCity.Documents.Pdf library. 
Loading is limit to 5 pages in unlicensed copy of this library.

## Settings
Printer name and listening port can be changed by modifying appsettings.json file.
By default printer name is 'Microsoft Print to PDF'. In this case to avoid prompting for a filename, the print agent saves the output pdf in a special system directory that contains documents that are common to all users.
By default, the service listens on http://localhost:5000. A PDF can be printed with a HTTP POST to http://localhost:5000/print.

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

To debug the sample and then run it, press F5 or select **Debug → Start Debugging**.
To run the sample without debugging, press Ctrl+F5 or select **Debug → Start Without Debugging**.
To run the sample in command line use the following command: **dotnet run --console**

## Install as Windows service

For install print agent as Windows service, do next:
1. Build the sample
2. Copy the content of the project build output folder into a specific folder (f.g. **C:\PrintAgent**). Output files are written into the default location, which is bin/<configuration>/<target>.
3. Run this command from a cmd window: **sc create PrintAgent binPath=C:\PrintAgent\PrintAgent.exe start=auto**
4. To start the service, run this command: **sc start PrintAgent**