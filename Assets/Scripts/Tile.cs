using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Action<Vector2> onTileClicked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        Console.WriteLine("ayyy I'm OnMouseDowning here(tile)");
        onTileClicked?.Invoke(this.transform.localPosition);
    }
}
