using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp {
	
	public class Tile {
		public IPlaceable PlaceableObject { get; set; }
		public TileType TileType { get; set; }
	}
}
