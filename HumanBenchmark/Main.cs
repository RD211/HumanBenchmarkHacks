using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using CefSharp.WinForms;
using CefSharp;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace HumanBenchmark
{
    public partial class Main : Form
    {
        public ChromiumWebBrowser browser;
       
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://humanbenchmark.com");
            this.Controls.Add(browser);
        }

        #region Constructor and on load
        public Main()
        {
            InitializeComponent();
            InitBrowser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Reaction time game
        int reactedThisManyTimes = 0;
        List<Color> colors = new List<Color>() { Color.FromArgb(43, 135, 209), Color.FromArgb(206, 38, 54), Color.FromArgb(75, 219, 106) };
        private void btn_reactionGame_Click(object sender, EventArgs e)
        {
            stopAllTimers();
            browser.Load("https://humanbenchmark.com/tests/reactiontime");
            while (browser.IsLoading)
            {
                System.Threading.Thread.Sleep(200);
            }

            var script = @"
            document.getElementsByClassName('view-splash e18o0sx0 css-saet2v e19owgy77')[0].dispatchEvent(new Event('mousedown', {     bubbles: true,     cancelable: true, }));
        ";
            browser.ExecuteScriptAsync(script);
            System.Threading.Thread.Sleep(200);
            reactionBotTimer.Enabled = true;
            reactionBotTimer.Start();
        }

        async private void reactionBotTimer_Tick(object sender, EventArgs e)
        {
            if (reactedThisManyTimes >= 5)
            {
                reactedThisManyTimes = 0;
                reactionBotTimer.Stop();
            }
            string html = (await browser.GetSourceAsync());
            if(html.Contains("view-go e18o0sx0 css-saet2v e19owgy77"))
            {
                var script = @"
            document.getElementsByClassName('view-go e18o0sx0 css-saet2v e19owgy77')[0].dispatchEvent(new Event('mousedown', {     bubbles: true,     cancelable: true, }));
        ";
                browser.ExecuteScriptAsync(script);
                System.Threading.Thread.Sleep(10);
                var script2 = @"
            document.getElementsByClassName('view-result e18o0sx0 css-saet2v e19owgy77')[0].dispatchEvent(new Event('mousedown', {     bubbles: true,     cancelable: true, }));
        ";
                reactedThisManyTimes++;
                if(reactedThisManyTimes!=5)
                browser.ExecuteScriptAsync(script2);
            }

        }
        #endregion

        #region Target game
        int shotThisManyTimes = 0;
        private void btn_targetBot_Click(object sender, EventArgs e)
        {
            stopAllTimers();

            browser.Load("https://humanbenchmark.com/tests/aim");
            while (browser.IsLoading)
            {
                System.Threading.Thread.Sleep(200);
            }

            var script = @"
            document.getElementsByClassName('css-qm0ri0 e19owgy710')[0].dispatchEvent(new Event('mousedown', {     bubbles: true,     cancelable: true, }));;
        ";
            browser.ExecuteScriptAsync(script);
            System.Threading.Thread.Sleep(200);
            targetBotTimer.Enabled = true;
            targetBotTimer.Start();
        }

        private void targetBotTimer_Tick(object sender, EventArgs e)
        {
            if(shotThisManyTimes==150)
            {
                targetBotTimer.Stop();
                targetBotTimer.Enabled = false;
                shotThisManyTimes = 0;
            }
            string script = @"document.getElementsByClassName('css-21ob1n e6yfngs0')[0].firstChild.dispatchEvent(new Event('mousedown', {     bubbles: true,     cancelable: true, }));";
            browser.ExecuteScriptAsync(script);
            shotThisManyTimes++;

        }
        #endregion

        #region Typing game
        private void btn_chimp_Click(object sender, EventArgs e)
        {
            stopAllTimers();

            browser.Load("https://humanbenchmark.com/tests/typing");
            while (browser.IsLoading)
            {
                System.Threading.Thread.Sleep(200);
            }
            System.Windows.Forms.Timer tempTimer = new System.Windows.Forms.Timer(this.components);
            tempTimer.Interval = 5000;
            tempTimer.Start();
            tempTimer.Enabled = true;
            tempTimer.Tick += (_, __) => {
                browser.GetSourceAsync().ContinueWith((res) => {
                    var html = res.Result;
                    StringBuilder builder = new StringBuilder();
                    builder.Append(Regex.Split(html, "<span class=\"incomplete current\">")[1].Split('<')[0]);
                    Regex.Split(html, "<span class=\"incomplete\">").Skip(1).ToList().ForEach((letter) =>
                    {
                        builder.Append(letter.Split('<')[0]);
                    });
                    SendKeys.SendWait(builder.ToString());
                    tempTimer.Enabled = false;
                    tempTimer.Stop();
                });
            };

        }
        #endregion

        #region Visual memory game
        //560 200
        //1400 630
        int levelsPassed = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            stopAllTimers();

            //browser.Url = new Uri("https://humanbenchmark.com/tests/memory");
            System.Threading.Thread.Sleep(2000);
            visualMemoryTimer.Enabled = true;
            visualMemoryTimer.Start();
        }

        private void visualMemoryTimer_Tick(object sender, EventArgs e)
        {

            //working on
            if(levelsPassed==50)
            {
                levelsPassed = 0;
                visualMemoryTimer.Stop();
                visualMemoryTimer.Enabled = false;
            }
            levelsPassed++;
        }
        #endregion

        #region Verbal memory game
        int words = 0;
        Dictionary<string, bool> wordsSoFar = new Dictionary<string, bool>();
        private void btn_verbalMemory_Click(object sender, EventArgs e)
        {
            stopAllTimers();

            browser.Load("https://humanbenchmark.com/tests/verbal-memory");
            System.Threading.Thread.Sleep(100);
            while (browser.IsLoading)
            {
                System.Threading.Thread.Sleep(200);
            }
            wordsSoFar = new Dictionary<string, bool>();

            var script = @"
            document.getElementsByClassName('css-qm0ri0 e19owgy710')[0].click();
        ";
            browser.ExecuteScriptAsync(script);
            System.Threading.Thread.Sleep(2000);
            verbalMemoryTimer.Enabled = true;
            verbalMemoryTimer.Start();
        }


        async private void verbalMemoryTimer_Tick(object sender, EventArgs e)
        {
            if (words >= 200000)
            {
                words = 0;
                verbalMemoryTimer.Stop();
            }
            words++;
            string html = (await browser.GetSourceAsync());
            string text = "";
            try
            {
                text = Regex.Split(Regex.Split(html, "<div class=\"word\">")[1], "<")[0];
            }
            catch { }
            if (wordsSoFar.ContainsKey(text))
            {
                var script = @"
            document.getElementsByClassName('css-qm0ri0 e19owgy710')[0].click();
        ";
                browser.ExecuteScriptAsync(script);

            }
            else
            {
                var script = @"
            document.getElementsByClassName('css-qm0ri0 e19owgy710')[1].click();
        ";
                browser.ExecuteScriptAsync(script);
                wordsSoFar.Add(text, true);
            }
        }
        #endregion

        #region Number memory game
        int numbers = 0;
        private void btn_numberMemory_Click(object sender, EventArgs e)
        {
            stopAllTimers();
            browser.Load("https://humanbenchmark.com/tests/number-memory");
            while (browser.IsLoading)
            {
                System.Threading.Thread.Sleep(200);
            }

            var script = @"
            document.getElementsByClassName('css-qm0ri0 e19owgy710')[0].click();
        ";
            browser.ExecuteScriptAsync(script);
            numberMemoryTimer.Enabled = true;
            numberMemoryTimer.Start();
        }
        Dictionary<char, int> fromCharToKeyCode = new Dictionary<char, int>() {
            {'0',0x30},
            {'1',0x31},
            {'2',0x32},
            {'3',0x33},
            {'4',0x34},
            {'5',0x35},
            {'6',0x36},
            {'7',0x37},
            {'8',0x38},
            {'9',0x39},
        };

        async private void numberMemoryTimer_Tick(object sender, EventArgs e)
        {
            if(numbers==100)
            {
                numbers = 0;
                numberMemoryTimer.Stop();
                numberMemoryTimer.Enabled = false;
            }
            numbers++;
            var html = await browser.GetSourceAsync();
            string text="";
            try
            {
                text = Regex.Split(Regex.Split(html, "<div class=\"big-number \">")[1], "<")[0];
            }
            catch { }
            if (text == "")
                return;
            while(true)
            {
                var html2 = await browser.GetSourceAsync();
                try
                {
                    string text2 = Regex.Split(Regex.Split(html2, "<div class=\"big-number \">")[1], "<")[0];
                    if (text != text2)
                        break;
                }
                catch { break; }
                System.Threading.Thread.Sleep(500);

            }
            var script = @"document.getElementsByClassName('css-qm0ri0 e19owgy710')[0].click();";
            text.ToList().ForEach((c) => {
                KeyEvent k = new KeyEvent
                {
                    WindowsKeyCode = fromCharToKeyCode[c],
                    IsSystemKey = false,
                    Type = KeyEventType.Char
                };
                browser.GetBrowser().GetHost().SendKeyEvent(k);
            });
            browser.ExecuteScriptAsync(script);
            browser.ExecuteScriptAsync(script);
            System.Threading.Thread.Sleep(200);
        }
        #endregion

        #region Safety
        private void safetyTimer_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Escape))
            {
                Environment.Exit(0);
            }
        }
        private void stopAllTimers()
        {
            numberMemoryTimer.Stop();
            verbalMemoryTimer.Stop();
            reactionBotTimer.Stop();
            visualMemoryTimer.Stop();
            targetBotTimer.Stop();
            wordsSoFar = new Dictionary<string, bool>();
            words = 0;
            numbers = 0;
            reactedThisManyTimes = 0;
            shotThisManyTimes = 0;
        }
        #endregion

    }
}
