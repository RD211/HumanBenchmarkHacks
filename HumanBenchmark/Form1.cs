using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Patagames.Ocr;
using Patagames.Ocr.Enums;
using System.Windows.Input;
namespace HumanBenchmark
{
    public partial class Form1 : Form
    {
        #region Constructor and on load
        public Form1()
        {
            InitializeComponent();
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
            System.Threading.Thread.Sleep(2000);
            reactionBotTimer.Enabled = true;
            reactionBotTimer.Start();
            
        }

        private void reactionBotTimer_Tick(object sender, EventArgs e)
        {
            var pixel = ScreenCapture.GetColorAtTwo(300,300);
            for (int i = 0; i < 3; i++)
            {
                if (Math.Abs(colors[i].R - pixel.R) + Math.Abs(colors[i].B - pixel.B) + Math.Abs(colors[i].G - pixel.G) <= 10)
                {
                    if (i != 1)
                    {
                        MouseOperations.SetCursorPosition(300, 300);
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                        reactedThisManyTimes++;
                        System.Threading.Thread.Sleep(400);
                    }
                }
            }
            if (reactedThisManyTimes == 10)
            {
                reactionBotTimer.Enabled = false;
                reactionBotTimer.Stop();
                reactedThisManyTimes = 0;
            }
        }
        #endregion

        #region Target game
        int shotThisManyTimes = 0;
        private void btn_targetBot_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            targetBotTimer.Start();
            targetBotTimer.Enabled = true;
        }

        private void targetBotTimer_Tick(object sender, EventArgs e)
        {
            if(shotThisManyTimes==150)
            {
                targetBotTimer.Stop();
                targetBotTimer.Enabled = false;
                shotThisManyTimes = 0;
            }
            var bmp = ScreenCapture.CaptureActiveWindow();
            for (int i = 0; i < 400; i += 2)
            {
                for (int j = 0; j < 1400; j += 2)
                {
                    var pixel = bmp.GetPixel(j + 300, i + 300);
                    if (Math.Abs(255 - pixel.R) + Math.Abs(255 - pixel.G) + Math.Abs(255 - pixel.B) <= 10)
                    {

                        MouseOperations.SetCursorPosition(j + 300,i+300);
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                        shotThisManyTimes++;
                        return;
                    }

                }
            }

        }
        #endregion

        #region Typing game
        private static Bitmap cropImage(DirectBitmap img, Rectangle cropArea)
        {
            return img.Bitmap.Clone(cropArea, img.Bitmap.PixelFormat);
        }
        private void btn_chimp_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            SendKeys.Send(this.txt_read.Text);
        }
        private void btn_readChimp_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            var bmp = ScreenCapture.CaptureActiveWindow();
            using (var api = OcrApi.Create())
            {
                api.Init(Languages.English);
                string plainText = api.GetTextFromImage(cropImage(bmp, new Rectangle(473, 364, 1419 - 473, 520 - 364)));
                bmp.Dispose();
                if (plainText[0] == '[')
                    plainText = plainText.Remove(0, 1);
                this.txt_read.Text = plainText.Replace("\n", "").Replace("\r", "");
            }
        }
        #endregion

        #region MouseLabelTimer
        private void updateMouseLabel_Tick(object sender, EventArgs e)
        {
            this.lbl_mousePos.Text = MousePosition.X + " " + MousePosition.Y;
        }
        #endregion

        #region Visual memory game
        //560 200
        //1400 630
        int levelsPassed = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            visualMemoryTimer.Enabled = true;
            visualMemoryTimer.Start();
        }

        private void visualMemoryTimer_Tick(object sender, EventArgs e)
        {
            if(levelsPassed==50)
            {
                levelsPassed = 0;
                visualMemoryTimer.Stop();
                visualMemoryTimer.Enabled = false;
            }
            levelsPassed++;
            var bmp = ScreenCapture.CaptureActiveWindow();

            bmp = new DirectBitmap(cropImage(bmp, new Rectangle(560, 200, 1400 - 560, 430)));
            List<Point> pointsToPress = new List<Point>();
            for(int i = 0;i<bmp.Height;i+=20)
            {
                for(int j = 0;j<bmp.Width;j+=20)
                {
                    int r = 0, g = 0, b = 0;
                    for(int ii = 0;ii<5;ii++)
                    {
                        for(int jj=0;jj<5;jj++)
                        {
                            var pixel = bmp.GetPixel(j + jj, i + ii);
                            r += pixel.R;
                            b += pixel.B;
                            g += pixel.G;
                        }
                    }
                    if(r+g+b>=250*3*25)
                    {
                        pointsToPress.Add(new Point(j, i));
                    }
                }
            }
            bmp.Dispose();
            System.Threading.Thread.Sleep(500);
            bool same = true;
            while(same)
            {
                same = false;
                var newBmp = ScreenCapture.CaptureActiveWindow();

                newBmp = new DirectBitmap(cropImage(newBmp, new Rectangle(560, 200, 1400 - 560, 430)));
                for (int i = 0; i < newBmp.Height; i += 20)
                {
                    for (int j = 0; j < newBmp.Width; j += 20)
                    {
                        int r = 0, g = 0, b = 0;
                        for (int ii = 0; ii < 5; ii++)
                        {
                            for (int jj = 0; jj < 5; jj++)
                            {
                                var pixel = newBmp.GetPixel(j + jj, i + ii);
                                r += pixel.R;
                                b += pixel.B;
                                g += pixel.G;
                            }
                        }
                        if (r + g + b >= 250 * 3 * 25)
                        {
                            same = true;
                        }
                    }
                }
                newBmp.Dispose();
                System.Threading.Thread.Sleep(500);
            }
            pointsToPress.ForEach((point) => {
                MouseOperations.SetCursorPosition(point.X + 560, point.Y + 200);
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);

            });
            GC.Collect();
            System.Threading.Thread.Sleep(750);
        }
        #endregion

        #region Verbal memory game
        int words = 0;
        Dictionary<string, bool> wordsSoFar = new Dictionary<string, bool>();
        private void btn_verbalMemory_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            wordsSoFar = new Dictionary<string, bool>();
            verbalMemoryTimer.Enabled = true;
            verbalMemoryTimer.Start();
        }

        private void verbalMemoryTimer_Tick(object sender, EventArgs e)
        {
            if(words>=200000)
            {
                words = 0;
                verbalMemoryTimer.Stop();
            }
            words++;
            var bmp = ScreenCapture.CaptureActiveWindow();
            using (var api = OcrApi.Create())
            {
                api.Init(Languages.English);
                var croppedImage = cropImage(bmp, new Rectangle(550, 340, 1350 - 550, 437 - 340));
                Bitmap resized = new Bitmap(croppedImage, new Size(croppedImage.Width / 2, croppedImage.Height / 2));
                string plainText = api.GetTextFromImage(resized);
                resized.Dispose();
                croppedImage.Dispose();

                if (wordsSoFar.ContainsKey(plainText))
                {
                    MouseOperations.SetCursorPosition(868, 480);
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                }
                else
                {
                    wordsSoFar.Add(plainText, true);
                    //1040 480
                    MouseOperations.SetCursorPosition(1040, 480);
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                }
            }


            bmp.Dispose();
            GC.Collect();

        }
        #endregion

        #region Number memory game
        int numbers = 0;
        private void btn_numberMemory_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            numberMemoryTimer.Enabled = true;
            numberMemoryTimer.Start();
        }
        private void numberMemoryTimer_Tick(object sender, EventArgs e)
        {
            if(numbers==100)
            {
                numbers = 0;
                numberMemoryTimer.Stop();
                numberMemoryTimer.Enabled = false;
            }
            numbers++;
            var bmp = ScreenCapture.CaptureActiveWindow();
            using (var api = OcrApi.Create())
            {
                api.Init(Languages.English);
                int other = 0;
                if(numbers>=18)
                {
                    other = 200;
                }
                var croppedImage = cropImage(bmp, new Rectangle(350, 150, 1650 - 350, 425 - 150+other));
                Bitmap resized = new Bitmap(croppedImage, new Size(croppedImage.Width / 4, croppedImage.Height / 4));
                croppedImage.Dispose();

                string plainText = api.GetTextFromImage(resized);
                resized.Dispose();
                plainText = plainText.Replace("O", "0");
                plainText = plainText.Replace("o", "0");
                plainText = plainText.Replace(" ", "");
                plainText = plainText.Replace("_", "");
                plainText = plainText.Replace("-", "");
                bool wait = true;
                while(wait)
                {
                    var newBmp = ScreenCapture.CaptureActiveWindow();
                    var newCroppedImage = cropImage(newBmp, new Rectangle(350, 150, 1650 - 350, 425 - 150+other));
                    Bitmap newResized = new Bitmap(newCroppedImage, new Size(newCroppedImage.Width / 4, newCroppedImage.Height / 4));
                    newCroppedImage.Dispose();

                    string plainText2 = api.GetTextFromImage(newResized);
                    newResized.Dispose();
                    plainText2 = plainText2.Replace("O", "0");
                    plainText2 = plainText2.Replace("o", "0");

                    plainText2 = plainText2.Replace(" ", "");
                    plainText2 = plainText2.Replace("_", "");
                    plainText2 = plainText2.Replace("-", "");


                    if (plainText!=plainText2)
                    {
                        wait = false;
                    }
                    System.Threading.Thread.Sleep(1000);
                    newBmp.Dispose();
                    GC.Collect();
                }
                MouseOperations.SetCursorPosition(990, 384);
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                System.Threading.Thread.Sleep(1000);
                SendKeys.Send(plainText.Replace("\n","").Replace("\r",""));
                System.Threading.Thread.Sleep(2000);
                SendKeys.Send("\n");

            }
            System.Threading.Thread.Sleep(2000);
            SendKeys.Send("\n");
            System.Threading.Thread.Sleep(10);
            MouseOperations.SetCursorPosition(100, 100);
            //962 542
            bmp.Dispose();
            GC.Collect();
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
        #endregion

    }
}
