using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButton : MonoBehaviour
{
    public Material material;

    private void OnMouseDown()
    {
        print("press");
    }
    private void OnMouseEnter()
    {
        
    }
    private void OnMouseExit()
    {
        material.color = Color.white;
    }
}
