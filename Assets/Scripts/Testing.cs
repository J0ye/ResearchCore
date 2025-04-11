using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
    public Vector2Int gridSize = Vector2Int.one;

    private Grid grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid(gridSize.x, gridSize.y, 5);        
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }
    }
}
