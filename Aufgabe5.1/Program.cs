using System;

namespace Aufgabe5._1
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Teil1();
            Teil1For();
        }

        private static void Teil2()
        {
            int triangleBaseLength = 9;
            int triangleHeight = 10;

            char indentChar = ' ';
            char fillChar = '+';
            int fillWidth = triangleBaseLength;
            int indentWidth = 0;

            bool isInverted = false;
            while (indentWidth < triangleHeight)
            //for (int indentWidth = 0; indentWidth < 5; indentWidth++)
            {
                if (fillWidth < 1)
                {
                    isInverted = true;
                    fillWidth = triangleBaseLength;
                }

                int tmpIndentWidth = indentWidth;
                int tmpFillWidth = fillWidth;

             

                if (!isInverted)
                {
                    while (tmpIndentWidth > 0)
                    {
                        Console.Write(indentChar);
                        tmpIndentWidth--;
                    }

                    while (tmpFillWidth > 0)
                    {
                        Console.Write(fillChar);
                        tmpFillWidth--;
                    }

                    fillWidth -= 2;
                }

                if (isInverted)
                {
                    while (tmpIndentWidth < triangleBaseLength)
                    {
                        Console.Write(indentChar);
                        tmpIndentWidth++;
                    }

                    while (tmpFillWidth >= triangleBaseLength)
                    {
                        Console.Write(fillChar);
                        tmpFillWidth--;
                    }

                    fillWidth += 2;
                }

                indentWidth++;
                Console.WriteLine();
            }
        }

        private static void Teil2For()
        {
            int triangleBaseLength = 9;
            int triangleHeight = triangleBaseLength / 2 + 1;

            char indentChar = ' ';
            char fillChar = '+';
            int fillWidth = triangleBaseLength;

            bool isInverted = false;
            
            for (int indentWidth = 0; indentWidth < triangleHeight; indentWidth++)
            {   
                int tmpIndentWidth = indentWidth;
                int tmpFillWidth = fillWidth;

                if (!isInverted)
                {
                    while (tmpIndentWidth > 0)
                    {
                        Console.Write(indentChar);
                        tmpIndentWidth--;
                    }

                    while (tmpFillWidth > 0)
                    {
                        Console.Write(fillChar);
                        tmpFillWidth--;
                    }

                    fillWidth -= 2;
                }

                if (isInverted)
                {
                    while (tmpIndentWidth < triangleBaseLength)
                    {
                        Console.Write(indentChar);
                        tmpIndentWidth++;
                    }

                    while (tmpFillWidth >= triangleBaseLength)
                    {
                        Console.Write(fillChar);
                        tmpFillWidth--;
                    }

                    fillWidth += 2;
                }

                indentWidth++;
                Console.WriteLine();
            }
        }

        private static void Teil1()
        {
            char indentChar = ' ';
            char fillChar = '+';
            int fillWidth = 9;

            int indentWidth = 0;
            while (indentWidth < 5)
            //for (int indentWidth = 0; indentWidth < 5; indentWidth++)
            {
                int tmpFillWidth = fillWidth;
                int tmpIndentWith = indentWidth;

                while (tmpIndentWith > 0)
                {
                    Console.Write(indentChar);
                    tmpIndentWith--;
                }

                while (tmpFillWidth > 0)
                {
                    Console.Write(fillChar);
                    tmpFillWidth--;
                }

                fillWidth -= 2;
                indentWidth++;

                Console.WriteLine();
            }
        }

        private static void Teil1For()
        {
            char indentChar = ' ';
            char fillChar = '+';
            int fillWidth = 9;
            
            for (int indentWidth = 0; indentWidth < 5; indentWidth++)
            {
                int tmpFillWidth = fillWidth;
                int tmpIndentWith = indentWidth;

                for (int i = tmpIndentWith; tmpIndentWith > 0; tmpIndentWith--)
                {
                    Console.Write(indentChar);
                }

                for (int i = tmpFillWidth; tmpFillWidth > 0; tmpFillWidth--)
                {
                    Console.Write(fillChar);
                }

                fillWidth -= 2;

                Console.WriteLine();
            }
        }

        private static void TeilExtra()
        {
            
        }
    }
}
