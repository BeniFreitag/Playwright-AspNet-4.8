using System;
using System.Threading.Tasks;
using System.Web.UI;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    private byte[] _pdfBinary;

    protected void Page_Load(object sender, EventArgs e)
    {
        RegisterAsyncTask(new PageAsyncTask(GeneratePdf));
    }

    private async Task GeneratePdf()
    {
        _pdfBinary = await new PdfService().GetPdf();

        Response.Clear();
        Response.ContentType = "application/pdf";
        Response.BinaryWrite(_pdfBinary);
        await Response.FlushAsync();
        Response.End();
    }
}