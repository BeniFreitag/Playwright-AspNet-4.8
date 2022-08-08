# Playwright 1.25.0 Demo with ASP.NET 4.8

This sample uses a fork of Playwright 1.25.0-alpha-jul-28-2022 which allows to specify the path to the .playwright-folder and solves the "Driver not found" exception:
 ```c#
 Playwright.CreateAsync(driversPath: "path-to/.playwright")
 ```



 This is a workaround/solution for:
  * [[Question]: How to set up a custom driver path? (Does not work with ASP.NET 4.8) #1842](https://github.com/microsoft/playwright-dotnet/issues/1842)
  * [[BUG]: .NET Framework 4.8 Driver not found in Temporary ASP.NET Files #2240
](https://github.com/microsoft/playwright-dotnet/issues/2240)
 * probably also [[BUG] Playwright does not work with packages.config (.NET 4.8) #2004
](https://github.com/microsoft/playwright-dotnet/issues/2004)