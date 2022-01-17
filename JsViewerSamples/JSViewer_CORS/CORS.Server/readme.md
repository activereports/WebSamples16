# Server application of the JS Viewer CORS sample

This sample demonstrates how to make a server that could be used by GrapeCity ActiveReports JSViewer. web.config contains CORS configuration.

## System requirements

This sample requires
[Visual Studio 2017](https://visualstudio.microsoft.com/vs/) or newer, and
the [.NET Framework Dev Pack](https://www.microsoft.com/net/download) 4.6.2 or later.

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

## Changing the client url

The client url is specified in the web.config as value of custom header "Access-Control-Allow-Origin".