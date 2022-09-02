using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Needed Methods:
//      - Generate Room
//
//
// Needed Properties:
//      - Size (n x m)
//      - Grid (n x m list of Tile class objects)
//      - Objectives (1 x i list of ???Objective class objects???)
//      - Key Objects and Object Placements (enemy number and starting locations perhaps, and starting locations for characters. 
//          Maybe doors to next room if we go with a door system. Maybe also list of interactable or non-interactable objects)


public class Room : MonoBehaviour
{
    private int x;
    private int y;
    private GameObject[,] grid;


    void Awake()
    {
        // Placeholder generation algorithm
        x = 9;
        y = 9;
        grid = new GameObject[x,y];
        for (int i=0;i<x;i++)
        {
            //grid[i] = gridRow
            for (int j=0;j<y;j++)
            {
                grid[i,j] = new GameObject();
                grid[i,j].AddComponent<Tile>();
                grid[i,j].transform.SetParent(gameObject.transform);
                grid[i,j].transform.localPosition = new Vector2(i,j);
                grid[i,j].AddComponent<SpriteRenderer>();
                grid[i,j].GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Square");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Updates at 50 fps/Hz
    void FixedUpdate()
    {
        
    }

    public Vector2 GetRoomSize()
    {
        return new Vector2(x,y);
    }
}
