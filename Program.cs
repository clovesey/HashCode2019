using System;
using System.IO;
using System.Windows;

namespace MainHashCode
{
    class Program
    {
        static int newID;
        static int ID;
        static int startingID = 0;
        static int SizeOfDataSet;
        static int currentImage;
        static void Main(string[] args)
        {
            int[,,,,] picture = new int[2, 2, 2, 2, 2];
            string[] tags = new string[2];
            SizeOfDataSet = picture.GetLength(0);

            string path = System.AppDomain.CurrentDomain.BaseDirectory + "slideshow.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter tw = new StreamWriter(path, true);
            CreateSlideShow(0, picture[0,0,0,0,0], tags, ref tw);
            tw.Close();
        }

        static int ImageCompare(int ID,string tags, int noTags, char orientation)
        {
            return 0;
        }


        static void CreateSlideShow(int currentIteration, int ID, string[] tags, ref StreamWriter tw)
        {
            if(SizeOfDataSet == currentIteration)
            {
                Console.WriteLine("I am finished! Slide show created!");
            }
            else
            {
                currentImage = ImageCompare(startingID, tags[startingID], 0, 'v');
                tw.WriteLine(currentImage);
                CreateSlideShow(currentIteration++, currentImage, tags, ref tw);
            }
        }
    }
}
