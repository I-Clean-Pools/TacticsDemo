using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class Guy : MonoBehaviour
{
    private bool isSelected;

    // Start is called before the first frame update
    void Start()
    {
        isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnSelect()
    {
        // Check if in a "select character to move" state
        // Check if mouse is over Guy
        // If so, light up valid tiles within range

        // Check if in "select where to move" state
        // If mouse over guy, do nothing
        // If mouse over valid tile, move Guy
        if (this._isValidStateToMoveGuy()) {
            if (this._isSelectingValidTarget()) this._moveGuy();
        } else if (this._isValidStateToSelectGuy()) {
            if (this._isSelectingGuy()) this._selectGuy();
        }
    }

    bool _isValidStateToMoveGuy(){
        return isSelected;
    }
    
    bool _isSelectingValidTarget(){
        return true;
    }

    bool _isValidStateToSelectGuy(){
        return !isSelected;
    }

    bool _isSelectingGuy(){
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;
        return (Physics.Raycast(ray, out hit) && hit.transform.name == "Guy");
    }

    void _selectGuy(){
        isSelected = true;
    }
    
    void _moveGuy(){
        this.transform.position = this._positionToTileCenterPosition(Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()));
    }

    Vector2 _positionToTileCenterPosition(Vector2 _position){
        return new Vector2((float)Math.Floor(_position.x+0.5f),(float)Math.Floor(_position.y+0.5f));
    }
}
