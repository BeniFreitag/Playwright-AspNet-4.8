using System.Threading.Tasks;
using System.Web.Hosting;
using Microsoft.Playwright;

namespace ClassLibrary;

public class PdfService
{
    public async Task<byte[]> GetPdf(string url = "https://github.com/microsoft/playwright")
    {
        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            ExecutablePath = HostingEnvironment.MapPath(@"~/ms-playwright/chromium-1015/chrome-win/chrome.exe")
        });
        var page = await browser.NewPageAsync();
        await page.GotoAsync(url);
        var binary = await page.PdfAsync();

        await browser.CloseAsync();
        playwright.Dispose();

        return binary;
    }
}

