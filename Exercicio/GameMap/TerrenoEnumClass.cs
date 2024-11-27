using System;

public enum TerrainEnum
{
    LAVA,
    MOUNTAIN,
    FOREST,
    WALL
}

public static class TerrainEnumExtensions
{
    public static ConsoleColor GetColor(this TerrainEnum terrain)
    {
        return terrain switch
        {
            TerrainEnum.LAVA => ConsoleColor.Red,
            TerrainEnum.MOUNTAIN => ConsoleColor.DarkGray,
            TerrainEnum.FOREST => ConsoleColor.Green,
            TerrainEnum.WALL => ConsoleColor.Gray,
            _ => ConsoleColor.White
        };
    }

    public static char GetChar(this TerrainEnum terrain)
    {
        return terrain switch
        {
            TerrainEnum.LAVA => '^',
            TerrainEnum.MOUNTAIN => '#',
            TerrainEnum.FOREST => 'T',
            TerrainEnum.WALL => '=',
            _ => '?'
        };
    }
}
