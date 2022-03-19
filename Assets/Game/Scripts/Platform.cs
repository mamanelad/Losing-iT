using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private void Awake()
    {
        var obj = gameObject;
        var pos = obj.transform.position;
        var scale = obj.transform.localScale;
        var minX = Mathf.RoundToInt(pos.x - (scale.x / 2));
        var minY = Mathf.RoundToInt(pos.y - (scale.y / 2));
        var maxX = Mathf.RoundToInt(pos.x + (scale.x / 2));
        var maxY = Mathf.RoundToInt(pos.y + (scale.y / 2));
        TetrisBlock.AddBlocksToGrid(minX, maxX, minY, maxY);
    }

    private void OnDisable()
    {
        var obj = gameObject;
        var pos = obj.transform.position;
        var scale = obj.transform.localScale;
        var minX = Mathf.RoundToInt(pos.x - (scale.x / 2));
        var minY = Mathf.RoundToInt(pos.y - (scale.y / 2));
        var maxX = Mathf.RoundToInt(pos.x + (scale.x / 2));
        var maxY = Mathf.RoundToInt(pos.y + (scale.y / 2));
        TetrisBlock.RemoveBlocksFromGrid(minX, maxX, minY, maxY);
    }
}
    