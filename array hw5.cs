using System;

namespace Array_Hw._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string image = Console.ReadLine();
            double[,] arrayimage = ReadImageDataFromFile(image);

            string convolution = Console.ReadLine();
            double[,] arrayconvolution = ReadImageDataFromFile(convolution);

            string output = Console.ReadLine();
            
            double[,] arrayrepeated = new double[7, 7];
            for (int i = 0; i < arrayimage.GetLength(0); i++)
            {
                for (int j = 0; j < arrayimage.GetLength(1); j++)
                {
                    arrayrepeated[i + 1, j + 1] = arrayimage[i, j];
                }
            }


            arrayrepeated[1, 6] = arrayrepeated[1, 1];
            arrayrepeated[6, 1] = arrayrepeated[1, 1];
            arrayrepeated[6, 6] = arrayrepeated[1, 1];
            arrayrepeated[6, 2] = arrayrepeated[1, 2];
            arrayrepeated[6, 3] = arrayrepeated[1, 3];
            arrayrepeated[6, 4] = arrayrepeated[1, 4];
            arrayrepeated[6, 5] = arrayrepeated[1, 5];
            arrayrepeated[2, 6] = arrayrepeated[2, 1];
            arrayrepeated[3, 6] = arrayrepeated[3, 1];
            arrayrepeated[4, 6] = arrayrepeated[4, 1];
            arrayrepeated[5, 6] = arrayrepeated[5, 1];
            arrayrepeated[6, 0] = arrayrepeated[1, 5];
            arrayrepeated[0, 6] = arrayrepeated[5, 1];
            arrayrepeated[0, 0] = arrayrepeated[5, 5];
            arrayrepeated[5, 0] = arrayrepeated[5, 5];
            arrayrepeated[0, 5] = arrayrepeated[5, 5];
            arrayrepeated[0, 1] = arrayrepeated[5, 1];
            arrayrepeated[0, 2] = arrayrepeated[5, 2];
            arrayrepeated[0, 3] = arrayrepeated[5, 3];
            arrayrepeated[0, 4] = arrayrepeated[5, 4];
            arrayrepeated[0, 5] = arrayrepeated[5, 5];
            arrayrepeated[1, 0] = arrayrepeated[1, 5];
            arrayrepeated[2, 0] = arrayrepeated[2, 5];
            arrayrepeated[3, 0] = arrayrepeated[3, 5];
            arrayrepeated[4, 0] = arrayrepeated[4, 5];
            arrayrepeated[5, 0] = arrayrepeated[5, 5];
            
            double[,] arrayconvolve = new double[5, 5];
            arrayconvolve[0, 0] = (arrayconvolution[0, 0] * arrayrepeated[0, 0]) + (arrayconvolution[0, 1] * arrayrepeated[0, 1]) + (arrayconvolution[0, 2] * arrayrepeated[0, 2]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[1, 0]) + (arrayconvolution[2, 0] * arrayrepeated[2, 0]) + (arrayconvolution[1, 1] * arrayrepeated[1, 1]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[1, 2]) + (arrayconvolution[2, 1] * arrayrepeated[2, 1]) + (arrayconvolution[2, 2] * arrayrepeated[2, 2]); 

            arrayconvolve[0, 1] = (arrayconvolution[0, 0] * arrayrepeated[0, 1]) + (arrayconvolution[0, 1] * arrayrepeated[0, 2]) + (arrayconvolution[0, 2] * arrayrepeated[0, 3]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[1, 1]) + (arrayconvolution[2, 0] * arrayrepeated[2, 1]) + (arrayconvolution[1, 1] * arrayrepeated[1, 2]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[1, 3]) + (arrayconvolution[2, 1] * arrayrepeated[2, 2]) + (arrayconvolution[2, 2] * arrayrepeated[2, 3]);

            arrayconvolve[0, 2] = (arrayconvolution[0, 0] * arrayrepeated[0, 2]) + (arrayconvolution[0, 1] * arrayrepeated[0, 3]) + (arrayconvolution[0, 2] * arrayrepeated[0, 4]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[1, 2]) + (arrayconvolution[2, 0] * arrayrepeated[2, 2]) + (arrayconvolution[1, 1] * arrayrepeated[1, 3]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[1, 4]) + (arrayconvolution[2, 1] * arrayrepeated[2, 3]) + (arrayconvolution[2, 2] * arrayrepeated[2, 4]);

            arrayconvolve[0, 3] = (arrayconvolution[0, 0] * arrayrepeated[0, 3]) + (arrayconvolution[0, 1] * arrayrepeated[0, 4]) + (arrayconvolution[0, 2] * arrayrepeated[0, 5]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[1, 3]) + (arrayconvolution[2, 0] * arrayrepeated[2, 3]) + (arrayconvolution[1, 1] * arrayrepeated[1, 4]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[1, 5]) + (arrayconvolution[2, 1] * arrayrepeated[2, 4]) + (arrayconvolution[2, 2] * arrayrepeated[2, 5]);

            arrayconvolve[0, 4] = (arrayconvolution[0, 0] * arrayrepeated[0, 4]) + (arrayconvolution[0, 1] * arrayrepeated[0, 5]) + (arrayconvolution[0, 2] * arrayrepeated[0, 6]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[1, 4]) + (arrayconvolution[2, 0] * arrayrepeated[2, 4]) + (arrayconvolution[1, 1] * arrayrepeated[1, 5]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[1, 6]) + (arrayconvolution[2, 1] * arrayrepeated[2, 5]) + (arrayconvolution[2, 2] * arrayrepeated[2, 6]);

            arrayconvolve[1, 0] = (arrayconvolution[0, 0] * arrayrepeated[1, 0]) + (arrayconvolution[0, 1] * arrayrepeated[1, 1]) + (arrayconvolution[0, 2] * arrayrepeated[1, 2]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[2, 0]) + (arrayconvolution[2, 0] * arrayrepeated[3, 0]) + (arrayconvolution[1, 1] * arrayrepeated[2, 1]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[2, 2]) + (arrayconvolution[2, 1] * arrayrepeated[3, 1]) + (arrayconvolution[2, 2] * arrayrepeated[3, 2]);

            arrayconvolve[2, 0] = (arrayconvolution[0, 0] * arrayrepeated[2, 0]) + (arrayconvolution[0, 1] * arrayrepeated[2, 1]) + (arrayconvolution[0, 2] * arrayrepeated[2, 2]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[3, 0]) + (arrayconvolution[2, 0] * arrayrepeated[4, 0]) + (arrayconvolution[1, 1] * arrayrepeated[3, 1]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[3, 2]) + (arrayconvolution[2, 1] * arrayrepeated[4, 1]) + (arrayconvolution[2, 2] * arrayrepeated[4, 2]);

            arrayconvolve[3, 0] = (arrayconvolution[0, 0] * arrayrepeated[3, 0]) + (arrayconvolution[0, 1] * arrayrepeated[3, 1]) + (arrayconvolution[0, 2] * arrayrepeated[3, 2]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[4, 0]) + (arrayconvolution[2, 0] * arrayrepeated[5, 0]) + (arrayconvolution[1, 1] * arrayrepeated[4, 1]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[4, 2]) + (arrayconvolution[2, 1] * arrayrepeated[5, 1]) + (arrayconvolution[2, 2] * arrayrepeated[5, 2]);
            
            arrayconvolve[4, 0] = (arrayconvolution[0, 0] * arrayrepeated[4, 0]) + (arrayconvolution[0, 1] * arrayrepeated[4, 1]) + (arrayconvolution[0, 2] * arrayrepeated[4, 2]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[5, 0]) + (arrayconvolution[2, 0] * arrayrepeated[6, 0]) + (arrayconvolution[1, 1] * arrayrepeated[5, 1]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[5, 2]) + (arrayconvolution[2, 1] * arrayrepeated[6, 1]) + (arrayconvolution[2, 2] * arrayrepeated[6, 2]);

            arrayconvolve[1, 1] = (arrayconvolution[0, 0] * arrayrepeated[1, 1]) + (arrayconvolution[0, 1] * arrayrepeated[1, 2]) + (arrayconvolution[0, 2] * arrayrepeated[1, 3]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[2, 1]) + (arrayconvolution[2, 0] * arrayrepeated[3, 1]) + (arrayconvolution[1, 1] * arrayrepeated[2, 2]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[2, 3]) + (arrayconvolution[2, 1] * arrayrepeated[3, 2]) + (arrayconvolution[2, 2] * arrayrepeated[3, 3]);

            arrayconvolve[1, 2] = (arrayconvolution[0, 0] * arrayrepeated[1, 2]) + (arrayconvolution[0, 1] * arrayrepeated[1, 3]) + (arrayconvolution[0, 2] * arrayrepeated[1, 4]) +
                                 (arrayconvolution[1, 0] * arrayrepeated[2, 2]) + (arrayconvolution[2, 0] * arrayrepeated[3, 2]) + (arrayconvolution[1, 1] * arrayrepeated[2, 3]) +
                                 (arrayconvolution[1, 2] * arrayrepeated[2, 4]) + (arrayconvolution[2, 1] * arrayrepeated[3, 3]) + (arrayconvolution[2, 2] * arrayrepeated[3, 4]);

            arrayconvolve[1, 3] = (arrayconvolution[0, 0] * arrayrepeated[1, 3]) + (arrayconvolution[0, 1] * arrayrepeated[1, 4]) + (arrayconvolution[0, 2] * arrayrepeated[1, 5]) +
                                 (arrayconvolution[1, 0] * arrayrepeated[2, 3]) + (arrayconvolution[2, 0] * arrayrepeated[3, 3]) + (arrayconvolution[1, 1] * arrayrepeated[2, 4]) +
                                 (arrayconvolution[1, 2] * arrayrepeated[2, 5]) + (arrayconvolution[2, 1] * arrayrepeated[3, 4]) + (arrayconvolution[2, 2] * arrayrepeated[3, 5]);

            arrayconvolve[1, 4] = (arrayconvolution[0, 0] * arrayrepeated[1, 4]) + (arrayconvolution[0, 1] * arrayrepeated[1, 5]) + (arrayconvolution[0, 2] * arrayrepeated[1, 6]) +
                                 (arrayconvolution[1, 0] * arrayrepeated[2, 4]) + (arrayconvolution[2, 0] * arrayrepeated[3, 4]) + (arrayconvolution[1, 1] * arrayrepeated[2, 5]) +
                                 (arrayconvolution[1, 2] * arrayrepeated[2, 6]) + (arrayconvolution[2, 1] * arrayrepeated[3, 5]) + (arrayconvolution[2, 2] * arrayrepeated[3, 6]);

            arrayconvolve[2, 1] = (arrayconvolution[0, 0] * arrayrepeated[2, 1]) + (arrayconvolution[0, 1] * arrayrepeated[2, 2]) + (arrayconvolution[0, 2] * arrayrepeated[2, 3]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[3, 1]) + (arrayconvolution[2, 0] * arrayrepeated[4, 1]) + (arrayconvolution[1, 1] * arrayrepeated[3, 2]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[3, 3]) + (arrayconvolution[2, 1] * arrayrepeated[4, 2]) + (arrayconvolution[2, 2] * arrayrepeated[4, 3]);

            arrayconvolve[2, 2] = (arrayconvolution[0, 0] * arrayrepeated[2, 2]) + (arrayconvolution[0, 1] * arrayrepeated[2, 3]) + (arrayconvolution[0, 2] * arrayrepeated[2, 4]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[3, 2]) + (arrayconvolution[2, 0] * arrayrepeated[4, 2]) + (arrayconvolution[1, 1] * arrayrepeated[3, 3]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[3, 4]) + (arrayconvolution[2, 1] * arrayrepeated[4, 3]) + (arrayconvolution[2, 2] * arrayrepeated[4, 4]);

            arrayconvolve[2, 3] = (arrayconvolution[0, 0] * arrayrepeated[2, 3]) + (arrayconvolution[0, 1] * arrayrepeated[2, 4]) + (arrayconvolution[0, 2] * arrayrepeated[2, 5]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[3, 3]) + (arrayconvolution[2, 0] * arrayrepeated[4, 3]) + (arrayconvolution[1, 1] * arrayrepeated[3, 4]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[3, 5]) + (arrayconvolution[2, 1] * arrayrepeated[4, 4]) + (arrayconvolution[2, 2] * arrayrepeated[4, 5]);

            arrayconvolve[2, 4] = (arrayconvolution[0, 0] * arrayrepeated[2, 4]) + (arrayconvolution[0, 1] * arrayrepeated[2, 5]) + (arrayconvolution[0, 2] * arrayrepeated[2, 6]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[3, 4]) + (arrayconvolution[2, 0] * arrayrepeated[4, 4]) + (arrayconvolution[1, 1] * arrayrepeated[3, 5]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[3, 6]) + (arrayconvolution[2, 1] * arrayrepeated[4, 5]) + (arrayconvolution[2, 2] * arrayrepeated[4, 6]);

            arrayconvolve[3, 1] = (arrayconvolution[0, 0] * arrayrepeated[3, 1]) + (arrayconvolution[0, 1] * arrayrepeated[3, 2]) + (arrayconvolution[0, 2] * arrayrepeated[3, 3]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[4, 1]) + (arrayconvolution[2, 0] * arrayrepeated[4, 2]) + (arrayconvolution[1, 1] * arrayrepeated[4, 2]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[4, 3]) + (arrayconvolution[2, 1] * arrayrepeated[5, 2]) + (arrayconvolution[2, 2] * arrayrepeated[5, 3]);

            arrayconvolve[3, 2] = (arrayconvolution[0, 0] * arrayrepeated[3, 2]) + (arrayconvolution[0, 1] * arrayrepeated[3, 3]) + (arrayconvolution[0, 2] * arrayrepeated[3, 4]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[4, 2]) + (arrayconvolution[2, 0] * arrayrepeated[4, 3]) + (arrayconvolution[1, 1] * arrayrepeated[4, 3]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[4, 4]) + (arrayconvolution[2, 1] * arrayrepeated[5, 3]) + (arrayconvolution[2, 2] * arrayrepeated[5, 4]);

            arrayconvolve[3, 3] = (arrayconvolution[0, 0] * arrayrepeated[3, 3]) + (arrayconvolution[0, 1] * arrayrepeated[3, 4]) + (arrayconvolution[0, 2] * arrayrepeated[3, 5]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[4, 3]) + (arrayconvolution[2, 0] * arrayrepeated[4, 4]) + (arrayconvolution[1, 1] * arrayrepeated[4, 4]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[4, 5]) + (arrayconvolution[2, 1] * arrayrepeated[5, 4]) + (arrayconvolution[2, 2] * arrayrepeated[5, 5]);

            arrayconvolve[3, 4] = (arrayconvolution[0, 0] * arrayrepeated[3, 4]) + (arrayconvolution[0, 1] * arrayrepeated[3, 5]) + (arrayconvolution[0, 2] * arrayrepeated[3, 6]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[4, 4]) + (arrayconvolution[2, 0] * arrayrepeated[4, 5]) + (arrayconvolution[1, 1] * arrayrepeated[4, 5]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[4, 6]) + (arrayconvolution[2, 1] * arrayrepeated[5, 5]) + (arrayconvolution[2, 2] * arrayrepeated[5, 6]);

            arrayconvolve[4, 1] = (arrayconvolution[0, 0] * arrayrepeated[4, 1]) + (arrayconvolution[0, 1] * arrayrepeated[4, 2]) + (arrayconvolution[0, 2] * arrayrepeated[4, 3]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[5, 1]) + (arrayconvolution[2, 0] * arrayrepeated[6, 1]) + (arrayconvolution[1, 1] * arrayrepeated[5, 2]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[5, 3]) + (arrayconvolution[2, 1] * arrayrepeated[6, 2]) + (arrayconvolution[2, 2] * arrayrepeated[6, 3]);

            arrayconvolve[4, 2] = (arrayconvolution[0, 0] * arrayrepeated[4, 2]) + (arrayconvolution[0, 1] * arrayrepeated[4, 3]) + (arrayconvolution[0, 2] * arrayrepeated[4, 4]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[5, 2]) + (arrayconvolution[2, 0] * arrayrepeated[6, 2]) + (arrayconvolution[1, 1] * arrayrepeated[5, 3]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[5, 4]) + (arrayconvolution[2, 1] * arrayrepeated[6, 3]) + (arrayconvolution[2, 2] * arrayrepeated[6, 4]);

            arrayconvolve[4, 3] = (arrayconvolution[0, 0] * arrayrepeated[4, 3]) + (arrayconvolution[0, 1] * arrayrepeated[4, 4]) + (arrayconvolution[0, 2] * arrayrepeated[4, 5]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[5, 3]) + (arrayconvolution[2, 0] * arrayrepeated[6, 2]) + (arrayconvolution[1, 1] * arrayrepeated[5, 4]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[5, 5]) + (arrayconvolution[2, 1] * arrayrepeated[6, 4]) + (arrayconvolution[2, 2] * arrayrepeated[6, 5]);

            arrayconvolve[4, 4] = (arrayconvolution[0, 0] * arrayrepeated[4, 1]) + (arrayconvolution[0, 1] * arrayrepeated[4, 2]) + (arrayconvolution[0, 2] * arrayrepeated[4, 3]) +
                                  (arrayconvolution[1, 0] * arrayrepeated[5, 1]) + (arrayconvolution[2, 0] * arrayrepeated[6, 1]) + (arrayconvolution[1, 1] * arrayrepeated[5, 2]) +
                                  (arrayconvolution[1, 2] * arrayrepeated[5, 3]) + (arrayconvolution[2, 1] * arrayrepeated[6, 2]) + (arrayconvolution[2, 2] * arrayrepeated[6, 3]);

            WriteImageDataToFile(output, arrayconvolve);
            
        }



        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }

        static void WriteImageDataToFile(string imageDataFilePath,
                                 double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }

    }
}
