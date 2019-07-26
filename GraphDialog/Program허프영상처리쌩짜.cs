using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using static ImageTest.ImageGrayEditor;

namespace ImageTest
{
    static class Program
    {
        public static void Main()
        {
            //Derivative filter
            int[,] filterDiff = {
                { 0, 1, 0 },
                { 1, -4, 1 },
                { 0, 1, 0 } };

            //Gausian smoothing filter(3 X 3)
            int[,] filterGausian3 = {
                { 1, 2, 1},
                { 2, 4, 2 },
                { 1, 2, 1 } };

            //Gausian smoothing filter(5 X 5)
            int[,] filterGausian5 = {
                { 1, 4, 7, 4, 1},
                { 4,16,26,16, 4},
                { 7,26,41,26, 7},
                { 4,16,26,16, 4},
                { 1, 4, 7, 4, 1} };

            //직선을 검출할 파일
            String dirName = @"C:\Users\kjh3864\Desktop\test\";

            ImageGrayEditor image = new ImageGrayEditor(dirName + "image.jpg");
            //이미지 스무딩(흐리게)
            image.Convolution(filterGausian5);
            image.Save(dirName + "image_blur.jpg");
            //이미지 미분(테두리 추출)
            image.Convolution(filterDiff);
            //이미지 이진화(흑백화)
            image.Save(dirName + "image_diff.jpg");

            //허프 좌표계
            int[,] houghMap = HoughLineDetect.GetMap(image.GetArray());
            //허프 좌표계를 이미지로 저장한다
            Graph.DrawDot(houghMap).Save(dirName + "hough.jpg");

            //이미지를 추출한다. 검출된 직선 중 30%의 직선만을 모은다.
            Point[] ps = HoughLineDetect.GetLines(houghMap, 0.7).ToArray();
            //이미지 위에 검출된 직선을 그린다.
            HoughLineDetect.DrawLines(new Bitmap(Image.FromFile(dirName + "image.jpg")), ps, Pens.Red).Save(dirName + "image_line.jpg");
        }
    }

    //이미지를 정수 배열로
    class ImageGrayEditor
    {
        public Bitmap bitmap;
        public BitmapData data;
        public int width;
        public int height;
        private int length;
        private int[,] imageArray;

        public ImageGrayEditor(string fileDir)
        {
            bitmap = new Bitmap(Image.FromFile(fileDir));
            Reload();
        }

        public ImageGrayEditor(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            Reload();
        }

        public ImageGrayEditor(int[,] array)
        {
            bitmap = new Bitmap(array.GetLength(1), array.GetLength(0));
            Reload();
            SetArray(array);
        }

        public void Reload()
        {
            Lock();
            imageArray = new int[(height = data.Height), (width = data.Stride / 3)];
            byte[] byteArray = new byte[length = data.Stride * data.Height];
            Marshal.Copy(data.Scan0, byteArray, 0, byteArray.Length);
            for (int y = 0; y < data.Height; y++)
            {
                for (int x = 0; x < data.Stride / 3; x++)
                {
                    int start = y * data.Stride + x * 3;
                    imageArray[y, x] = (
                      byteArray[start]
                    + byteArray[start + 1]
                    + byteArray[start + 2]) / 3;
                }
            }
            UnLock();
        }

        public int[,] GetArray()
        {
            return imageArray;
        }

        public void SetArray(int[,] array)
        {
            Lock();
            imageArray = array;
            byte[] byteArray = new byte[length];
            for (int y = 0; y < data.Height; y++)
            {
                for (int x = 0; x < data.Stride / 3; x++)
                {
                    int value = imageArray[y, x];
                    if (value < 0)
                    {
                        value = 0;
                    }
                    else if (value > 255)
                    {
                        value = 255;
                    }
                    int start = y * data.Stride + x * 3;
                    byteArray[start] = byteArray[start + 1] = byteArray[start + 2] = (byte)value;
                }
            }
            Marshal.Copy(byteArray, 0, data.Scan0, length);
            UnLock();
        }

        //컨볼루션.
        public bool Convolution(int[,] filter)
        {
            int widthFilter = filter.GetLength(1);
            int heightFilter = filter.GetLength(0);
            if (widthFilter == heightFilter && widthFilter % 2 == 1)
            {
                int sum = 0;
                foreach (int i in filter)
                {
                    sum += i;
                }


                int[,] output = new int[height, width];
                int lengthH = widthFilter / 2;
                for (int y = lengthH; y < height - lengthH; y++)
                {
                    for (int x = lengthH; x < width - lengthH; x++)
                    {
                        int value = 0;
                        for (int i = 0; i < heightFilter; i++)
                        {
                            for (int j = 0; j < widthFilter; j++)
                            {
                                value += imageArray[y - lengthH + i, x - lengthH + j]
                                       * filter[i, j];
                            }
                        }
                        if (sum > 0) { value /= sum; }
                        if (value > 255)
                        {
                            value = 255;
                        }
                        else if (value < 0)
                        {
                            value = 0;
                        }
                        output[y, x] = value;
                    }
                }
                SetArray(output);
                return true;
            }
            return false;
        }

        //이미지의 히스토그램을 구한다.
        public int[] GetHistogram()
        {
            int[] output = new int[256];
            for (int i = 0; i < imageArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageArray.GetLength(1); j++)
                {
                    output[imageArray[i, j]]++;
                }
            }
            return output;
        }

        public void Save(string saveDir)
        {
            SetArray(imageArray);
            bitmap.Save(saveDir);
        }

        public void Lock()
        {
            data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
        }

        public void UnLock()
        {
            bitmap.UnlockBits(data);
        }

        public void Binarization(int threshold)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (imageArray[y, x] > threshold)
                    {
                        imageArray[y, x] = 255;
                    }
                    else
                    {
                        imageArray[y, x] = 0;
                    }
                }
            }
        }

        public class HoughLineDetect
        {
            //이진화된 이미지의 모든 점들로부터 직선을 구해서, 허프 좌표게에 그린다.
            public static int[,] GetMap(int[,] binary)
            {
                int width, height;
                int rMax = (int)(Math.Sqrt(Math.Pow((height = binary.GetLength(0)), 2) + Math.Pow((width = binary.GetLength(1)), 2)) + 1);
                int thetaMax = 180;

                int[,] hough = new int[thetaMax, rMax * 2];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (binary[y, x] > 127)
                        {
                            foreach (Point p in GetLines(x, y))
                            {
                                hough[p.X, p.Y + rMax]++;
                            }
                        }
                    }
                }
                return hough;
            }

            //허프 좌표계에서 threshold(0~1)비율의 선들만을 추출한다.(표현이 애매하네요...)
            public static List<Point> GetLines(int[,] hough, double threshold)
            {
                if (0 > threshold || threshold > 1)
                {
                    throw new Exception("Wrong threshold. threshold should be between 0 and 1");
                }
                int rMax = hough.GetLength(1) / 2;
                double threshold_ = GetMaximum(hough) * threshold;
                List<Point> output = new List<Point>();
                for (int theta = 0; theta < hough.GetLength(0); theta++)
                {
                    for (int r = 0; r < hough.GetLength(1); r++)
                    {
                        if (hough[theta, r] > threshold_)
                        {
                            output.Add(new Point(theta, r - rMax));
                        }
                    }
                }
                return output;
            }

            //선들을 주어진 그림 위에 그린다.
            public static Bitmap DrawLines(Bitmap bitmap, Point[] lines, Pen pen)
            {
                Graphics g = Graphics.FromImage(bitmap);
                foreach (Point p in lines)
                {
                    try
                    {
                        double theta = p.X * Math.PI / 180;
                        double a = -Math.Cos(theta) / Math.Sin(theta);
                        double b = p.Y / Math.Sin(theta);

                        Point p1 = new Point(0, (int)b);
                        Point p2 = new Point(bitmap.Width, (int)(a * bitmap.Width + b));
                        g.DrawLine(pen, p1, p2);
                    }
                    catch
                    {

                    }
                }
                return bitmap;
            }

            //한 점으로부터 나오는 모든 허프 좌표계의 점(=원래 좌표계에서 직선)들을 구한다.
            private static Point[] GetLines(int x, int y)
            {
                Point[] output = new Point[180];
                double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                for (int theta = 0; theta < 180; theta++)
                {
                    double theta_ = theta * Math.PI / 180.0;
                    double r = x * Math.Cos(theta_) + y * Math.Sin(theta_);
                    output[theta] = new Point(theta, (int)(r));
                    if (r - 1 > d)
                    {
                        throw new Exception("Calculation error - d=" + d + ", r=" + r);
                    }
                }
                return output;
            }

            private static int GetMaximum(int[,] data)
            {
                int max = Int32.MinValue;
                foreach (int i in data)
                {
                    max = Math.Max(max, i);
                }
                return max;
            }
        }
    }

    class Graph
    {
        //배열의 극대값과 극솟값을 구한다.
        public static void GetExtrimum(int[] data, out int max, out int min)
        {
            min = Int32.MaxValue;
            max = Int32.MinValue;
            foreach (int i in data)
            {
                max = Math.Max(max, i);
                min = Math.Min(min, i);
            }
        }
        public static void GetExtrimum(int[,] data, out int max, out int min)
        {
            min = Int32.MaxValue;
            max = Int32.MinValue;
            foreach (int i in data)
            {
                max = Math.Max(max, i);
                min = Math.Min(min, i);
            }
        }

        //이차원 배열에서 극대값만을 구한다. 사용하지 않는 메서드.
        public static int[,] GetLocalMaximumㅣㅐㅊ미ㅁ(int[,] data)
        {
            int[,] output = (int[,])data.Clone();
            for (int i = 1; i < data.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < data.GetLength(1) - 1; j++)
                {
                    int v = data[i, j];
                    if (v > data[i + 1, j] && v > data[i, j + 1] && v > data[i - 1, j] && v > data[i - 1, j] &&
                        v > data[i + 1, j + 1] && v > data[i + 1, j - 1] && v > data[i - 1, j + 1] && v > data[i - 1, j - 1])
                    {
                        output[i, j] = 255;
                    }
                    else
                    {
                        output[i, j] = 0;
                    }
                }
            }
            return output;
        }

        //배열을 최댓값과 최솟값 사이로 사영한다.
        public static int[] IntoRange(int[] data, int min, int max)
        {
            GetExtrimum(data, out int max_, out int min_);
            int height = max - min;
            int height_ = max_ - min_;
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (data[i] - min) * height / height_;
            }
            return data;
        }
        public static int[,] IntoRange(int[,] data, int min, int max)
        {
            GetExtrimum(data, out int max_, out int min_);
            int height = max - min;
            int height_ = max_ - min_;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = (data[i, j] - min_) * height / height_ + min;
                }
            }
            return data;
        }

        //산포도 그래프를 만든다.
        public static Bitmap DrawDot(int[] data)
        {
            GetExtrimum(data, out int min, out int max);
            Bitmap image = new Bitmap(data.Length, max - min + 1);
            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] array = new byte[bitmapData.Stride * bitmapData.Height];
            //Data.Length < bitmapData.Stride;
            for (int i = 0; i < data.Length; i++)
            {
                int y = bitmapData.Height - (data[i] - min) - 1;
                int x = i * 3;
                int start = (y * bitmapData.Stride + x);

                //                Console.WriteLine(x + "," + y + " : " + image.Height + " :" + start + "/" + array.Length);
                array[start] = array[start + 1] = array[start + 2] = 255;
            }

            Marshal.Copy(array, 0, bitmapData.Scan0, array.Length);
            image.UnlockBits(bitmapData);
            Graphics.FromImage(image).DrawLine(Pens.White,
                0, bitmapData.Height + min - 1,
                data.Length, bitmapData.Height + min - 1);
            return image;
        }
        public static Bitmap DrawDot(int[,] data)
        {
            Bitmap image = new Bitmap(data.GetLength(1), data.GetLength(0));
            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] array = new byte[bitmapData.Stride * bitmapData.Height];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j] < 0)
                    {
                        data[i, j] = 0;
                    }
                    else if (data[i, j] > 255)
                    {
                        data[i, j] = 255;
                    }
                    int y = i;
                    int x = j * 3;
                    int start = (y * bitmapData.Stride + x);
                    array[start] = array[start + 1] = array[start + 2] = (byte)(data[i, j]);
                }
            }

            Marshal.Copy(array, 0, bitmapData.Scan0, array.Length);
            image.UnlockBits(bitmapData);
            return image;
        }

        //선형(꺾은선) 그래프를 만든다.
        public static Bitmap DrawLine(int[] data)
        {
            GetExtrimum(data, out int max, out int min);
            Bitmap b = new Bitmap(data.Length, max - min + 1);
            //xMax = data.L-1;
            //yMax = max-min;
            Point[] ps = new Point[data.Length];
            for (int i = 0; i < ps.Length; i++)
            {
                ps[i] = new Point(i, max - data[i]);
            }
            Graphics g = Graphics.FromImage(b);
            g.DrawLines(Pens.White, ps);
            int y = max - min;
            g.DrawLine(Pens.White, 0, y, data.Length, y);
            return b;
        }
    }
}