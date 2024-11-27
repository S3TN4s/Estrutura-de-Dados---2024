using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        TerrainEnum[,] map =
        {
            { TerrainEnum.LAVA, TerrainEnum.LAVA, TerrainEnum.LAVA, TerrainEnum.FOREST, TerrainEnum.FOREST },
            { TerrainEnum.MOUNTAIN, TerrainEnum.MOUNTAIN, TerrainEnum.FOREST, TerrainEnum.FOREST, TerrainEnum.WALL },
            { TerrainEnum.LAVA, TerrainEnum.FOREST, TerrainEnum.FOREST, TerrainEnum.WALL, TerrainEnum.WALL },
            { TerrainEnum.MOUNTAIN, TerrainEnum.MOUNTAIN, TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.WALL }
        };

        Console.OutputEncoding = UTF8Encoding.UTF8;

        for (int row = 0; row < map.GetLength(0); row++)
        {
            for (int column = 0; column < map.GetLength(1); column++)
            {
                Console.ForegroundColor = map[row, column].GetColor();
                Console.Write(map[row, column].GetChar() + " ");
            }
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
