using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTempbyType : MonoBehaviour
{
    public string input;
    public SpriteRenderer spr;

    void Start()
    {
        spr.color = Color.white;
    }
    // Update is called once per frame
    public void GetTemp(string s)
    {
        input = s;
        //Debug.Log(input);
        ColorChange();

    }
    public void ColorChange ()
    {
        if (input == "Cold")
        {
            spr.color = Color.blue;
        }
        else if (input == "cold")
        {
            spr.color = Color.blue;
        }
        else if (input == "Hot")
        {
            spr.color = Color.red;
        }
        else if (input == "hot")
        {
            spr.color = Color.red;
        }
        else if (input == "Cool")
        {
            spr.color = Color.cyan;
        }
        else if (input == "cool")
        {
            spr.color = Color.cyan;
        }
        else if (input == "Warm")
        {
            spr.color = Color.yellow;
        }
        else if (input == "warm")
        {
            spr.color = Color.yellow;
        }
        else
        {
            spr.color = Color.white;
        }
    }
    void Update()
    {
        //GetTemp();
        
    }
}
