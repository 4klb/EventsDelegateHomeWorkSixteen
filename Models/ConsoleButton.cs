using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ConsoleButton
    {
        public event Action<int> ButtonAction;
        public string Boundary { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
        public ConsoleColor InsideColor { get; set; }
        public ConsoleColor BoundaryColor { get; set; }

        public void Button()
        {
            PrintButton();
            ButtonAction?.Invoke(42);
        }

        public void PrintButton()
        {
            string[,] Array = new string[Width, Height];
            Console.BackgroundColor = BoundaryColor;

            for (int i = 0; i < Width; i++) //row
            {
                for (int j = 0; j < Height; j++) //column
                {
                    if (i == 0 || j == 0 || i == Width - 1)
                    {
                        Array[i, j] = Boundary;
                        Console.Write(Array[i, j]);
                        Console.ForegroundColor = InsideColor;
                    }
                    else if (j == Width - 1)
                    {
                        int cursorPosition = Height - 1;
                        Console.CursorLeft = cursorPosition;
                        Console.Write(Boundary);
                        Console.Write(Array[i, j]);
                    }
                    if (i == Width / 3 && j == Height / 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\t\b{Text}");
                        Console.ForegroundColor = InsideColor;
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
