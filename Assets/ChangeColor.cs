using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeColor : MonoBehaviour
{
    SpriteRenderer spr;
    public ColorScriptableObject input;

    void Start()
    {
        spr = GetComponent<SpriteRenderer>();

    }

    void OnEnable()
    {
        ChangeTempbyType.TempSet += ColorChange;
    }

    void OnDisable()
    {
        ChangeTempbyType.TempSet -= ColorChange;
    }

   public void ColorChange()
    {
        spr.color = Color.white;
        if (input.value == "Cold")
        {
            spr.color = Color.blue;
        }
        else if (input.value == "cold")
        {
            spr.color = Color.blue;
        }
        else if (input.value == "Hot")
        {
            spr.color = Color.red;
        }
        else if (input.value == "hot")
        {
            spr.color = Color.red;
        }
        else if (input.value == "Cool")
        {
            spr.color = Color.cyan;
        }
        else if (input.value == "cool")
        {
            spr.color = Color.cyan;
        }
        else if (input.value == "Warm")
        {
            spr.color = Color.yellow;
        }
        else if (input.value == "warm")
        {
            spr.color = Color.yellow;
        }
        else
        {
            spr.color = Color.white;
        }
    }
}
