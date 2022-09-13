using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour
{
    public Action<Vector2> onTileClicked;

    public void Init() {

    }

    void OnMouseEnter() {

        Debug.Log("OnMouseEnter!!");
    }

    void OnMouseDown() {
        Debug.Log("Hello!!");
        onTileClicked?.Invoke(this.transform.localPosition);
    }
}
