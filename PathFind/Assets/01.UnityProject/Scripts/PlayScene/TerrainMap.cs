using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMap : MonoBehaviour
{
    private const string TERRAIN_TILEMAP_OBJ_NAME = "TerrainTilemap";

    private Vector2Int mapCellSize = default;
    private Vector2 mapCellGap = default;

    private List<TerrainControler> allTerrains = default;

}
