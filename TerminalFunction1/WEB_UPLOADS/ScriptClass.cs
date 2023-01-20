using Microsoft.Web.WebView2.WinForms;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEB_UPLOADS
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class ScriptClass
    {
        public WebView2 WebView2 { get; set; }

        public ScriptClass()
        {
        }

        public void CallFuncFromJavascriptPowerClose()
        {
            CloseAndDispose();
        }

        public void CloseAndDispose()
        {
            Program.FM00000X.Close();
            Program.FM00000X.Dispose();
        }

        public async Task<string> GetElementsValue(string elements)
        {
            string request = "document.getElementById('" + elements + "').value;";
            string results = await WebView2.ExecuteScriptAsync(request);
            return results;
        }

        public async void SetElementsValue(string id, string values)
        {
            await WebView2.ExecuteScriptAsync("document.getElementById('" + id + "')" + ".value=" + values);
        }

        public async void CallJavaScript(string scripts, string param)
        {
            await WebView2.ExecuteScriptAsync(scripts + "(" + param + ")");
        }

    }
}
