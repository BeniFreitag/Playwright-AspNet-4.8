using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Web.Http;
using Microsoft.Playwright;

namespace WebApplication.Controllers;

[RoutePrefix("api/Playwright")]
public class PlaywrightController : ApiController
{
    [HttpGet]
    [Route("")]
    public async Task<HttpResponseMessage> Get(string url = "https://github.com/microsoft/playwright")
    {
        var playwright = await Playwright.CreateAsync();

        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            ExecutablePath = HostingEnvironment.MapPath(@"~/ms-playwright/chromium-1015/chrome-win/chrome.exe")
        });
        var page = await browser.NewPageAsync();
        await page.GotoAsync(url);
        var pdfBinary = await page.PdfAsync();

        await browser.CloseAsync();
        playwright.Dispose();

        var response = Request.CreateResponse(HttpStatusCode.OK);
        response.Content = new ByteArrayContent(pdfBinary);
        response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
        return response;
    }
}
