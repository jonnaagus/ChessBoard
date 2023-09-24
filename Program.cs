namespace ChessBoard
{
    // Skapad av: Jonna Gustafsson  
    // Klass: .NET23

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Var god och skriv in antal rader och kolumner på schackbrädet:");

            // Read users input and convert to an integer
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                DrawChessBoard(size);
            }
            else
            {
                Console.WriteLine("Felaktig inmatning. Var god och ange ett positivt heltal, tack.");
            }
        }

        // Code for a method that will draw the chessboard in the console in the size that the user has decided 
        static void DrawChessBoard(int size)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    // Code for the black and white squares based on even/odd positions
                    if ((row + column) % 2 == 0)
                    {
                        Console.Write("◼︎");
                    }
                    else
                    {
                        Console.Write("◻︎");
                    }
                }
                Console.WriteLine(); // New line after each row
            }
        }
    }
}