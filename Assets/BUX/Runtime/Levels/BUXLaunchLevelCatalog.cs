using System.Collections.Generic;
using BUX.Runtime.Core;

namespace BUX.Runtime.Levels
{
    public static class BUXLaunchLevelCatalog
    {
        public const int LaunchLevelCount = 120;

        public static IReadOnlyList<BUXLevelSpec> CreateDefaultLaunchCatalog()
        {
            var levels = new List<BUXLevelSpec>(LaunchLevelCount);
            for (var i = 1; i <= LaunchLevelCount; i++)
            {
                var worldIndex = (i - 1) / 20;
                var difficulty = 1 + ((i - 1) % 20) / 3;
                levels.Add(new BUXLevelSpec
                {
                    LevelId = i,
                    WorldId = WorldIdForIndex(worldIndex),
                    Width = 8,
                    Height = 8,
                    Seed = 10000 + i * 7919,
                    MoveLimit = System.Math.Max(18, 34 - difficulty),
                    DifficultyScore = System.Math.Min(10, difficulty + worldIndex),
                    PrimaryTileObjective = TileForLevel(i),
                    PrimaryTarget = 18 + difficulty * 3,
                    IntroducedBlocker = BlockerForWorld(worldIndex)
                });
            }

            return levels;
        }

        private static string WorldIdForIndex(int index)
        {
            return index switch
            {
                0 => "berry_village",
                1 => "mossy_forest",
                2 => "picnic_path",
                3 => "honey_hills",
                4 => "magic_clearing",
                _ => "champion_grove"
            };
        }

        private static TileId TileForLevel(int level)
        {
            return (level % 7) switch
            {
                0 => TileId.Acorn,
                1 => TileId.RedBerry,
                2 => TileId.Blueberry,
                3 => TileId.GreenLeaf,
                4 => TileId.PinkFlower,
                5 => TileId.WhiteDaisy,
                _ => TileId.Mushroom
            };
        }

        private static BlockerKind BlockerForWorld(int worldIndex)
        {
            return worldIndex switch
            {
                1 => BlockerKind.Moss,
                2 => BlockerKind.Pebble,
                3 => BlockerKind.Ice,
                4 => BlockerKind.CoveredMoss,
                5 => BlockerKind.Vine,
                _ => BlockerKind.None
            };
        }
    }
}
