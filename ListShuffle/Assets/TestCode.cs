using UnityEngine;
using System.Collections.Generic;

public class TestCode : MonoBehaviour
{
    List<int> list = new List<int>{ 1, 2, 3, 4, 5 };

    /// <summary>
    /// リストのシャッフルをおこないそれをログに表示する
    /// </summary>
    void Start()
    {
        var afterList = ListShuffle.GetListShuffle( list );
        afterList.ForEach( v => Debug.Log( v ) ); 
    }
}
