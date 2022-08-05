# Playwright 1.24.1 Demo with ASP.NET 4.8

Steps to reproduce:
1) Open the solution in Visual Studio.
2) Run either WebApplication or Website (via F5).
3) You'll see an exception:
```
Driver not found: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\vs\6c77f81d\ac62943a\assembly\dl3\.playwright\node\win32_x64\playwright.cmd

Stack Trace:
[PlaywrightException: Driver not found: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\vs\6c77f81d\ac62943a\assembly\dl3\.playwright\node\win32_x64\playwright.cmd]
   Microsoft.Playwright.Helpers.Driver.GetExecutablePath() in /_/src/Playwright/Helpers/Driver.cs:57
   Microsoft.Playwright.Transport.StdIOTransport.GetProcess() in /_/src/Playwright/Transport/StdIOTransport.cs:119
   Microsoft.Playwright.Transport.StdIOTransport..ctor() in /_/src/Playwright/Transport/StdIOTransport.cs:44
   Microsoft.Playwright.<CreateAsync>d__0.MoveNext() in /_/src/Playwright/Playwright.cs:44
   System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw() +32
   System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task) +62
   System.Runtime.CompilerServices.TaskAwaiter`1.GetResult() +32
   ClassLibrary.<GetPdf>d__0.MoveNext() in C:\Projects\Playwright-AspNet-4.8\ClassLibrary\PdfService.cs:11
   System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw() +32
   System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task) +62
   System.Runtime.CompilerServices.TaskAwaiter`1.GetResult() +32
   <GeneratePdf>d__0.MoveNext() in c:\Projects\Playwright-AspNet-4.8\Website\Default.aspx.cs:17
   System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw() +32
   System.Web.UI.<ExecuteTasksAsync>d__3.MoveNext() +450
   System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw() +32
   System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task) +62
   System.Web.UI.<ProcessRequestAsync>d__554.MoveNext() +981
```