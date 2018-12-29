using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Web;
using System.Diagnostics;

namespace VideoOnCmder
{
    public partial class Main : Form
    {
        string[] args = Environment.GetCommandLineArgs();

        public Main()
        {
            InitializeComponent();
            embeddedVideoScreen.ScriptErrorsSuppressed = true;

            if (args.Count() == 2)
            {
                searchBox.Text = args[1].ToString();
            }

            try
            {
                // this assumes that you've added an instance of WebBrowser and named it webBrowser to your form  
                SHDocVw.WebBrowser_V1 window = (SHDocVw.WebBrowser_V1)embeddedVideoScreen.ActiveXInstance;
                // listen for new windows 
                window.NewWindow += window_NewWindow;
            }
            catch
            {
                //empty.
            }
        }

        private void window_NewWindow(string URL, int Flags, string TargetFrameName, ref object PostData, string Headers, ref bool Processed)
        {
 
            Processed = true;
            OpenVideo(URL);

        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchBox.Visible = false;
                OpenVideo(searchBox.Text);
            } 
        }

        private void OpenVideo(string url)
        {
            if (url == "https://youtube.com/" || url.Contains("twitter") || url.Contains("facebook") || url.Contains("plus.google") || url.Contains("youtube.com/signin") || url.Contains("youtube.com/channel/") || url.Contains("action=share"))
            {
                //do something when pressed irrelevant url..
            }
            else if(searchBox.Text.Contains("youtube") == true)
            {
                OpenYoutubeVideo(GetYouTubeVideoIdFromUrl(url));
            }
            else
            {
                //for debug
                MessageBox.Show(url);
            }
        }

        private void menu_exit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_fullview_click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = args[0].ToString();
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            //gönderilecek parametre, form inlize() sonrası göndereceğimiz argümanları okumamız ve ona göre tepki vermemiz gerekiyor
            //program sadece consol üstünden çalıştırılmaya göre tasarlanmalı
            // 
            cmd.StandardInput.WriteLine("putty");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            
            //this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void menu_search_click(object sender, EventArgs e)
        {
            if (searchBox.Visible == false)
            {
                searchBox.Visible = true;
            }
            else
            {
                searchBox.Visible = false;
            }
        }

        private void menu_hide_click(object sender, EventArgs e)
        {
            //todo
        }

        static private string GetYouTubeVideoIdFromUrl(string url)
        {
            Uri uri = null;
            if (!Uri.TryCreate(url, UriKind.Absolute, out uri))
            {
                try
                {
                    uri = new UriBuilder("http", url).Uri;
                }
                catch
                {
                    // invalid url
                    return "";
                }
            }

            string host = uri.Host;
            string[] youTubeHosts = { "www.youtube.com", "youtube.com", "youtu.be", "www.youtu.be" };
            if (!youTubeHosts.Contains(host))
                return "";

            var query = HttpUtility.ParseQueryString(uri.Query);

            if (query.AllKeys.Contains("v"))
            {
                return Regex.Match(query["v"], @"^[a-zA-Z0-9_-]{11}$").Value;
            }
            else if (query.AllKeys.Contains("u"))
            {
                // some urls have something like "u=/watch?v=AAAAAAAAA16"
                return Regex.Match(query["u"], @"/watch\?v=([a-zA-Z0-9_-]{11})").Groups[1].Value;
            }
            else
            {
                // remove a trailing forward space
                var last = uri.Segments.Last().Replace("/", "");
                if (Regex.IsMatch(last, @"^v=[a-zA-Z0-9_-]{11}$"))
                    return last.Replace("v=", "");

                string[] segments = uri.Segments;
                if (segments.Length > 2 && segments[segments.Length - 2] != "v/" && segments[segments.Length - 2] != "watch/")
                    return "";

                return Regex.Match(last, @"^[a-zA-Z0-9_-]{11}$").Value;
            }
        }

        private void OpenYoutubeVideo(string id)
        {
            var embed = "<html style='height:100%'><head>" +
                "<meta http-equiv='X-UA-Compatible' content='IE=Edge; width=device-width; height=device-height;'>" +
                "</head><body style='height:100%;margin-left:0;margin-top:0;margin-right:0; margin-bottom:0;' marginheight=0 marginwidth=0>" +
                "<iframe style='display:block; width:100%; height:100%' src='{0}'" +
                "frameborder = 0 allow ='autoplay; encrypted-media' allowfullscreen></iframe>" +
                "</body></html>";

            var url = "https://www.youtube.com/embed/" + id + "?modestbranding=1&autoplay=1&enablejsapi=1&iv_load_policy=0";
            embeddedVideoScreen.DocumentText = string.Format(embed, url);
        }
    } 
}
