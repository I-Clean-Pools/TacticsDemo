using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
 
    private Vector2 selectedPosition;
    private Dictionary<Vector2, Tile> grid;

    public Action<Vector2> onSelectedPositionUpdated;

    [SerializeField] private Tile _tilePrefab;

    void Awake()
    {
        Debug.Log("Test!!!");
        Console.WriteLine("Hello!!!");
        // Placeholder generation algorithm
        x = 9;
        y = 9;
        grid = new Dictionary<Vector2, Tile>();
        for (int i=0;i<x;i++)
        {
            for (int j=0;j<y;j++)
            {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(i, j), Quaternion.identity);
                spawnedTile.name = $"Tile {i} {j}";
                spawnedTile.Init();

                grid[new Vector2(i, j)] = spawnedTile;
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

    void UpdateSelectedPosition(Vector2 newPosition) {
        onSelectedPositionUpdated?.Invoke(newPosition);
        selectedPosition = newPosition;
    }

    public Vector2 GetRoomSize()
    {
        return new Vector2(x,y);
    }
}
