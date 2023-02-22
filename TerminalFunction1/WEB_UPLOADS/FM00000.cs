using System;

using CommonBase;
using CommonBase.BaseForms;
using CommonBase.Alerts;
using Microsoft.Web.WebView2.Core;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Net;
using System.Text;
using CommonBase.Logs;
using System.Diagnostics;
using System.Configuration;

namespace WEB_UPLOADS
{
    [ComVisible(true)]
    public partial class FM00000 : BaseForm
    {
        private bool bolFinish;
        public ScriptClass objBridgeScriptClass = null;

        public FM00000()
        {
            base.InitializeComponent();
            InitializeComponent();
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);
            }
            catch (Exception ex)
            {
                // webview2 runtime install を促す
                MessageBox.Show(ex.ToString());
            }
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            try
            {
                cmdLoad_Click(cmdLoad, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FM00000_Load(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            this.Width = 1050;
            this.Height = 600;

            GetAppSettings();

            tsmMenu4_sub1.Checked = true;

            this.toolStripStatusLabel1.Text = "v1.0";
            this.toolStripStatusLabel2.Text = "2022/10/15 15:22";
            this.toolStripStatusLabel3.Text = "";
            this.toolStripStatusLabel4.Text = "";
            this.toolStripStatusLabel5.Text = "";
        }
        private void GetAppSettings()
        {
            try
            {
                Global.OPERATION_MODE = ConfigurationManager.AppSettings["OPERATION_MODE"];

                switch (Global.OPERATION_MODE)
                {
                    case "OPERATIONAL":
                        ParentURL.PURL = ConfigurationManager.AppSettings["URL_OPERATIONAL"];
                        break;
                    case "OLD":
                        ParentURL.PURL = ConfigurationManager.AppSettings["URL_OLD"];
                        break;
                    case "AWS":
                        ParentURL.PURL = ConfigurationManager.AppSettings["URL_AWS"];
                        break;
                    case "LOCAL":
                        ParentURL.PURL = ConfigurationManager.AppSettings["URL_LOCAL"];
                        break;
                    default:
                        ParentURL.PURL = "http://localhost/WebEntry2022VS/";
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            webView21.AllowExternalDrop = false;
            objBridgeScriptClass = new ScriptClass();
            objBridgeScriptClass.WebView2 = webView21;
            webView21.CoreWebView2.AddHostObjectToScript("BridgeScriptClassWebUpload", objBridgeScriptClass);
            webView21.CoreWebView2.Navigate(ParentURL.PURL + "Login.aspx");
        }

        private async void webView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            try
            {
                Text = webView21.CoreWebView2.Source;
                toolStripStatusLabel5.Text = webView21.CoreWebView2.DocumentTitle;

/*
                if (webView21.CoreWebView2.DocumentTitle.Equals("Login"))
                {
                    // 隠し項目の設定
                    var hidden01 = await objBridgeScriptClass.GetElementsValue("hidden01");
                    if (hidden01.Length != 0)
                    {
                        string strSSL = CIniFile.bSSL ? "" : "1";
                        objBridgeScriptClass.CallJavaScript_hiddenset(strSSL);
                    }
                }
*/

                // Cookieの保存
                var CookieList = await GetCookiesAsyncCall();
                GetCookiesAsyncLocal(CookieList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task<List<CoreWebView2Cookie>> GetCookiesAsyncCall()
        {
            var CookieList = await webView21.CoreWebView2.CookieManager.GetCookiesAsync(null);  //ドメインを指定しなければ null

            for (int ii = 0; ii < CookieList.Count; ii++)
            {
                Console.WriteLine($"name={CookieList[ii].Name}, value={CookieList[ii].Value}, tostring={CookieList[ii].ToString()}");
            }
            return CookieList;
        }

        private void GetCookiesAsyncLocal(List<CoreWebView2Cookie> CookieList)
        {
            // Cookie 保存
            StringBuilder stbCookie = new StringBuilder();
            for (int ii = 0; ii < CookieList.Count; ii++)
            {
                stbCookie.Append($"{CookieList[ii].Name}={CookieList[ii].Value}");
                if (ii < CookieList.Count - 1)
                {
                    stbCookie.Append(";");
                }
            }
            Retention.cookies = stbCookie.ToString();

            // Cookie Container 保存
            Retention.cookeiescontainer = new CookieContainer();
            for (int ii = 0; ii < CookieList.Count; ii++)
            {
                Cookie newCookie = new Cookie(CookieList[ii].Name, CookieList[ii].Value);
                newCookie.Domain = Common.ExtractHostDomain(ParentURL.PURL);
                Retention.cookeiescontainer.Add(newCookie);
            }
        }

        private async void webView21_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string msg = e.TryGetWebMessageAsString();

            switch (msg)
            {
                case "Open Scoreing Dialog.":
                    {
                        // URLの取得
                        var apl_target_url = await objBridgeScriptClass.GetElementsValue("apl_target_url");
                        if (apl_target_url.Length == 0)
                        {
                            return;
                        }
                        apl_target_url = apl_target_url.Trim('"');

                        // Show a modal dialog after the current event handler is completed,
                        // to avoid potential reentrancy caused by running a nested message loop in the WebView2 event handler.
                        System.Threading.SynchronizationContext.Current.Post((_) => {
                            OpenScoreingDialog(apl_target_url);
                        }, null);
                        break;
                    }
                default:
                    {
                        MessageBox.Show("既定外の処理要求を受け付けました。", "WebMessageReceived");
                        break;
                    }
            }
        }

        public void OpenScoreingDialog(string URL)
        {
        }

        private void FM00000_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");
        }

        private void FM00000_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");
        }

        private void tsmMenu1_sub2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmMenu4_sub1_Click(object sender, EventArgs e)
        {
            this.statusStrip1.Visible = tsmMenu4_sub1.Checked ? true : false;
        }

    }
}
