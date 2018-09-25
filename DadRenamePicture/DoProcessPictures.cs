using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DadRenamePicture
{

     
    class DoProcessPictures
    {
        Color CAMERA_DATE_COLOR = Color.FromArgb(255, 255, 103, 0);

        BackgroundWorker worker;

        public void DoProcessPictures_DoWork(object sender, DoWorkEventArgs e)
        {
            worker = sender as BackgroundWorker;
            string[] args = e.Argument as string[];
            string sourcefolder = args[0];
            string targetFolder = args[1];
            int dateSize = int.Parse(args[2]);
            bool shouldAddDate = Convert.ToBoolean(args[3]);
            int hourModifier = int.Parse(args[4]);
            String colorName = args[5];
            int horizontalOffset = int.Parse(args[6]);
            int verticalOffset = int.Parse(args[7]);

            RenamePicturesAndAddTime(sourcefolder, targetFolder, dateSize, shouldAddDate, hourModifier, colorName, horizontalOffset, verticalOffset);
        }


        private void RenamePicturesAndAddTime(string picPath, string picTargetPath, int dateSize, bool shouldAddDate, int hourModifier, String colorName,int horizontalOffset,int verticalOffset)
        {
            List<string> fileList = Directory.EnumerateFiles(picPath).ToList();
          

            for (int i = 0; i<fileList.Count ; i++)
            {
                string fileName = fileList[i];

                if (fileName.EndsWith("jpg", StringComparison.CurrentCultureIgnoreCase))
                {

                    //-----------------------------------------------------------
                    DateTime dt;
                    int picOrientation;
                    string cameraName;
                    string locationString;
                    GetPropertyItemsFromImage(fileName, out dt, out picOrientation, out cameraName,out locationString, hourModifier);
                    string cleanFileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);
                    string newName = (shouldAddDate?"" + dt.Year.ToString("D4") + dt.Month.ToString("D2") + dt.Day.ToString("D2") + dt.Hour.ToString("D2") + dt.Minute.ToString("D2") + dt.Second.ToString("D2") + "_" + cleanFileName:cleanFileName);
                    worker.ReportProgress((i * 100) / fileList.Count);
                    string strDateTime = dt.ToString("dd/MM/yyyy HH:mm:ss");

                    doAddDateTimeToFile(fileName, picTargetPath + "\\" + newName, strDateTime, dateSize, picOrientation, shouldAddDate, cameraName, colorName, horizontalOffset, verticalOffset, locationString);
                }

            }
        }

        public static void GetPropertyItemsFromImage(string path,out DateTime picDate, out int picOrientation, out string cameraName,out string locationString,int hourModifier)
        {
            Regex r = new Regex(":");

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                if (myImage.PropertyIdList.Contains(36867))
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    picDate = DateTime.Parse(dateTaken);
                }
                else
                {
                    picDate = File.GetLastWriteTime(path);
                }

                if (myImage.PropertyIdList.Contains(0x112))
                {
                    PropertyItem propItem = myImage.GetPropertyItem(0x112);

                    picOrientation = propItem.Value[0];
                }
                else
                {
                    picOrientation = 1;
                }

                picDate = picDate.AddHours(hourModifier);

                try
                {
                    cameraName = System.Text.Encoding.UTF8.GetString(myImage.GetPropertyItem(271).Value);
                }
                catch
                {
                    cameraName = "FUJIFILM";
                }


               

                locationString = ProcessGPS.GetGPSLocation(myImage);
                
            }
        }




        private void doAddDateTimeToFile(string sourceFileName, string targetFileName, string dateTimeString, int dateSize, int picOrientation, bool shouldAddDate, string cameraName, string colorName, int horizontalOffset, int verticalOffset, string locationString)
        {

            int dateSizeDevisor = (isRegularCamreaFormat(cameraName) ? 600 : 100);
            int fontSizeModifier = (isRegularCamreaFormat(cameraName)  ? 150 : 100);
            Bitmap bitmap = null;

            // Create from a stream so we don't keep a lock on the file.
            var stream = File.OpenRead(sourceFileName);
            bitmap = (Bitmap)Bitmap.FromStream(stream);
            var graphics = Graphics.FromImage(bitmap);
            //removeOrangeDate(picOrientation, bitmap, graphics);
            setOrientation(picOrientation, bitmap);
            addDate(dateTimeString, dateSize, shouldAddDate, cameraName, colorName, horizontalOffset, verticalOffset, locationString, dateSizeDevisor, fontSizeModifier, bitmap, graphics);
            try { bitmap.Save(targetFileName); }
            catch(Exception e){
                Debug.WriteLine("exception:" + e.Data);
            }
         
        }

        private static void setOrientation(int picOrientation, Bitmap bitmap)
        {
            if (picOrientation == 6)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);

            }
            else if (picOrientation == 8)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);

            }
        }

        private static void addDate(string dateTimeString, int dateSize, bool shouldAddDate, string cameraName, string colorName, int horizontalOffset, int verticalOffset, string locationString, int dateSizeDevisor, int fontSizeModifier, Bitmap bitmap, Graphics graphics)
        {
            if (shouldAddDate)
            {
                float fontSize = bitmap.Size.Height * dateSize / dateSizeDevisor; //100
                fontSize = (cameraName.IndexOf("OLYMPUS") > -1 ? fontSize * 4 : fontSize);
                float fontXCorner = 200 + horizontalOffset * 50;
                float fontYCorenr = bitmap.Size.Height - fontSize - fontSizeModifier + verticalOffset * 50;
                var font = new Font("Arial", fontSize, FontStyle.Regular);


                Color textColor = Color.FromName(colorName);

                if (locationString.Length == 0)
                {
                    graphics.DrawString(dateTimeString, font, new SolidBrush(textColor), fontXCorner, fontYCorenr);
                }
                else
                {
                    graphics.DrawString(dateTimeString, font, new SolidBrush(textColor), fontXCorner, fontYCorenr - fontSize * 4);

                    var locationFont = new Font("Arial", fontSize * 2 / 3, FontStyle.Regular);
                    graphics.DrawString(locationString, locationFont, new SolidBrush(textColor), fontXCorner, fontYCorenr);
                }


            }
        }

        private void removeOrangeDate(int picOrientation, Bitmap bitmap, Graphics graphics)
        {

            ArrayList datePointList = new ArrayList();

            int xStart = 0;
            int yStart = 0;
            int width = 0;
            int height = 0;
         
            if (picOrientation == 1)
            {
                xStart = 2845;
                yStart = 2440;
                width = 600;
                height = 100;
            }
            else
            {
                xStart = 3300;
                yStart = 240 ;
                width = 100;
                height = 600;
            }

            Color pixelColor = bitmap.GetPixel(xStart-1, yStart-1);
            Brush avgBrush = new SolidBrush(pixelColor);
            graphics.FillRectangle(avgBrush, xStart, yStart, width, height);

            /*
            for (int x = xStart; x < bitmap.Size.Width; x++)
            {
                for (int y = yStart; y < bitmap.Size.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    if (pixelColor == CAMERA_DATE_COLOR)
                    {
                        datePointList.Add(new Point(x, y));

                    }
                }
            }

            Boolean progress = true;

            while (datePointList.ToArray().Length > 0 && progress)
            {
                List<Point> healedPoints = new List<Point>();
                for (int dpindex = 0; dpindex < datePointList.ToArray().Length; dpindex++)
                {
                    Boolean isHealed = healPointColor(bitmap, graphics, (Point)datePointList[dpindex]);
                    if (isHealed)
                    {
                        healedPoints.Add((Point)datePointList[dpindex]);
                    }
                }
                if (healedPoints.ToArray().Length > 0)
                {
                    foreach (Point p in healedPoints)
                    {
                        datePointList.Remove(p);
                    }

                }
                else
                {
                    progress = false;
                }
            }*/
        }

        private Boolean healPointColor(Bitmap bitmap, Graphics graphics, Point healPoint)
        {
            List<Color> surroundingColors = new List<Color>();
            for (int x = -1; x < 2; x++)
            {
                for (int y = -1; y < 2; y++)
                {
                   
                        Color pixelColor = bitmap.GetPixel(healPoint.X + x, healPoint.Y+y);
                        if (pixelColor != CAMERA_DATE_COLOR)
                        {
                            surroundingColors.Add(pixelColor);
                        }
                   
                }
            }

            int nonOrangeColors = surroundingColors.ToArray().Length;
            if (nonOrangeColors > 3)
            {
                int sumRed=0;
                int sumGreen=0;
                int sumBlue=0;

                foreach(Color col in surroundingColors) {
                    
                    sumRed+=(col.R & 0xFFFF);
                    sumGreen+=(col.G & 0xFFFF);
                    sumBlue+=(col.B & 0xFFFF);

                }
                Color avgColor = Color.FromArgb(255, sumRed / nonOrangeColors, sumGreen / nonOrangeColors, sumBlue / nonOrangeColors);
                Brush avgBrush = new SolidBrush(Color.Purple);
                graphics.FillRectangle(avgBrush, healPoint.X, healPoint.Y, 1, 1);
              
                return true;
            }
            return false;
        }
        private bool isRegularCamreaFormat(string cameraName)
        {
            return (cameraName.IndexOf("OLYMPUS") > -1 || cameraName.IndexOf("SONY") > -1);
        }

    }

   

}
