using System;
using UnityEngine;

namespace AssemblyCSharp {
	
	public class LevelLoader {

		private string _filePath;

		public LevelLoader(string filePath) {
			_filePath = filePath;
		}

		public Level Load() {
			var map = Resources.Load<Texture2D>(_filePath);
			var level = new Level();
			var pixelData = map.GetPixels();
			var worldX = GameConstants.WorldX;
			var worldY = GameConstants.WorldY;

			level.Tiles = new Tile[worldX, worldY];

			for (int x = 0; x < level.Tiles.GetLength(0); x++) {
				for (int y = 0; y < level.Tiles.GetLength(1); y++) {
					var tile = new Tile();
					tile.TileType = getTileType(pixelData[x + (y * worldX)]);
					level.Tiles[x, y] = tile;
				}
			}

			return level;
		}

		private TileType getTileType(Color pixelColour) {
			if (pixelColour == Color.green) return TileType.Start;
			if (pixelColour == Color.red) return TileType.End;
			if (pixelColour == Color.blue) return TileType.Empty;
			return TileType.Wall;
		}
	}
}

