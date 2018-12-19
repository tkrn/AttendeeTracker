using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace AttendeeTracker
{
    class AttendeeBadge
    {
        private Image _image;
        private String _path;
        static private String _tempPath = Path.Combine(
                Environment.GetEnvironmentVariable("TEMP"),
                "AttendeeTracker"
                );

        public AttendeeBadge()
        {
            if (!Directory.Exists(_tempPath))
            {
                try
                {
                    Directory.CreateDirectory(_tempPath);
                }
                catch (Exception) { }
            }
        }

        public bool CreateNameBadge(String NameLine, String CompanyLine)
        {
            // Dymo 30857 Name Badge Labels
            // 57mm * 102mm = 215px * 385px
            Bitmap img = new Bitmap(1604, 896);
            img.SetResolution(300, 300);

            Graphics drawing = Graphics.FromImage(img);

            Font fontNameLine = new System.Drawing.Font(
                "Arial",
                32F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0))
            );

            Font fontCompanyLine = new System.Drawing.Font(
                "Arial",
                22F,
                System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0))
            );

            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            drawing.Clear(Color.Transparent);

            // Attendee name line
            SizeF sizeNameLine = drawing.MeasureString(NameLine, fontNameLine);
            int nLeftNameLine = Convert.ToInt32((img.Width / 2) - (sizeNameLine.Width / 2));
            int nTopNameLine = Convert.ToInt32(((img.Height / 5) * 2) - (sizeNameLine.Height / 2));
            drawing.DrawString(NameLine, fontNameLine, Brushes.Black, nLeftNameLine, nTopNameLine);

            // Company name line
            SizeF sizeCompanyLine = drawing.MeasureString(CompanyLine, fontCompanyLine);
            int nLeftCompanyLine = Convert.ToInt32((img.Width / 2) - (sizeCompanyLine.Width / 2));
            int nTopCompanyLine = Convert.ToInt32(((img.Height / 5) * 3) - (sizeCompanyLine.Height / 2));
            drawing.DrawString(CompanyLine, fontCompanyLine, Brushes.Black, nLeftCompanyLine, nTopCompanyLine);

            // Bottom right logo
            Image logo;

            if (File.Exists("logo.png")) {
                logo = Image.FromFile("logo.png");
            }
            else
            {
                logo = Properties.Resources.default_logo;
            }
       
            Rectangle logoRectangle = new Rectangle();
            logoRectangle.Width = 315;
            logoRectangle.Height = 315;
            logoRectangle.X = img.Width - logoRectangle.Width;
            logoRectangle.Y = img.Height - logoRectangle.Height;
            drawing.DrawImage(logo, logoRectangle);

            drawing.Save();
            drawing.Dispose();

            String imagePath = Path.Combine(
                _tempPath,
                String.Format("{0}.png", Guid.NewGuid().ToString())
                );

            try
            {
                img.Save(imagePath, ImageFormat.Png);
                _image = img;
                _path = imagePath;
                return true;
            }
            catch (Exception)
            {
                _image = null;
                _path = null;
                return false;
            }
        }

        public Image GetImage()
        {
            return _image;
        }

        public String GetPath()
        {
            return _path;
        }
    }
}
