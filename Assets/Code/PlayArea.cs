using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using AssemblyCSharp;

public class PlayArea : MonoBehaviour {

	public GameObject WallPefab;
	public GameObject StartPrefab;
	public GameObject EndPrefab;
	public GameObject EmptyPrefab;
	public string Level;

	// Use this for initialization
	void Start() {
		var levelLoader = new LevelLoader(Level);
		var level = levelLoader.Load();

		for (int x = 0; x < level.Tiles.GetLength(0); x++) {
			for (int y = 0; y < level.Tiles.GetLength(1); y++) {
				GameObject tileObject;
				var tileType = level.Tiles[x, y].TileType;

				switch (tileType) {
				case TileType.Wall:
					tileObject = Instantiate(WallPefab) as GameObject;
					break;
				case TileType.Start:
					tileObject = Instantiate(StartPrefab) as GameObject;
					break;
				case TileType.End:
					tileObject = Instantiate(EndPrefab) as GameObject;
					break;
				default:
					tileObject = Instantiate(EmptyPrefab) as GameObject;
					break;
				}

				tileObject.transform.SetParent(this.gameObject.transform, false);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
