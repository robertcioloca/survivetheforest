namespace SurviveTheForest.Core;

public class Map
{
    public TileTypes[][] Tiles { get; private set; }
    public int[][] Monsters { get; private set; }
    public int[][] PowerUps { get; private set; }
    private readonly Random Rng = new();
    private enum Directions
    {
        North,
        East,
        South,
        West,
    }

    public enum TileTypes
    {
        Tree,
        Path,
    }

    public Map(int width, int height)
    {
        FillTrees(width, height);
        CarveInitialPaths();
        Monsters = new int[0][];
        PowerUps = new int[0][];
    }

    private void FillTrees(int width, int height)
    {
        Tiles = new TileTypes[height][];
        for (var i = 0; i < height; i++)
        {
            Tiles[i] = new TileTypes[width];
            for (var j = 0; j < width; j++)
            {
                Tiles[i][j] = TileTypes.Tree;
            }
        }
    }

    private void CarveInitialPaths()
    {
        var middleX = Tiles[0].Length / 2;
        var middleY = Tiles.Length / 2;
        Tiles[middleY][middleX] = TileTypes.Path;
        var branches = Rng.Next(3, 5);
        while (branches > 0)
        {
            var numberToPlace = Rng.Next(1, Tiles.Length / 2);
            var direction = (Directions)Rng.Next(0, 4);
            int[] heading = [0, 0];
            switch (direction)
            {
                case Directions.North:
                    heading = [-1, 0];
                    break;
                case Directions.East:
                    heading = [0, 1];
                    break;
                case Directions.South:
                    heading = [1, 0];
                    break;
                case Directions.West:
                    heading = [0, -1];
                    break;
                default:
                    break;
            }

            if (Tiles[middleY + heading[0]][middleX + heading[1]] == TileTypes.Path)
            {
                continue;
            }

            for (var i = 1; i <= numberToPlace; i++)
            {
                Tiles[middleY + (heading[0] * i)][middleX + (heading[1] * i)] = TileTypes.Path;
            }

            branches--;
        }
    }
}
