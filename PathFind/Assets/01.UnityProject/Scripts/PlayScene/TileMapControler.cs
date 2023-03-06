using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapControler : MonoBehaviour
{
    protected string tileMapObjName = default;

    protected MapBoard mapControler = default;
    protected Tilemap tileMap = default;
    protected List<GameObject> allTileObjs = default;


    //! Awake 타임에 초기화할 내용을 상속받은 클래스 별로 재정의한다.
    public virtual void InitAwake(MapBoard mapControler_)
    {
        mapControler = mapControler_;
        tileMap = gameObject.FindChildObjComponent<Tilemap>(tileMapObjName);

        // 직사각형 형태로 초기화된 타일을 캐싱해서 사지고 있는다.
        //allTileObjs =
    }   // InitAwake()
}   // class TileMapControler
