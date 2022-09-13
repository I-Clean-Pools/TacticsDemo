using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class Guy : MonoBehaviour
{
    private bool isSelected;
    public Room room;

    // Start is called before the first frame update
    void Start()
    {
        isSelected = false;
        this.room.onSelectedPositionUpdated += _moveGuy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Console.WriteLine("ayyy I'm OnMouseDowning here");
        isSelected = true;
    }
    
    void _moveGuy(Vector2 toPos){
        this.transform.position = toPos;
        isSelected = false;
    }

}
