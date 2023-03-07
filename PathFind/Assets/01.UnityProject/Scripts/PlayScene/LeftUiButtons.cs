using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftUiButtons : MonoBehaviour
{
    //! A star find path 버튼을 누른 경우
    public void OnClickAstarFindBtn()
    {
        //GFunc.Log("A* 알고리즘으로 길찾기 버튼을 클릭했다.");

        PathFinder.Instance.FindPath_Astar();
    }   // OnClickAstarFindBtn()
}
