using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ChangeTempbyType : MonoBehaviour
{
    public ColorScriptableObject input;
    public static event Action TempSet;

    public void GetTemp(string s)
    {
        input.value = s;
        if (TempSet != null)
        {
            TempSet.Invoke();
        }
        //Debug.Log(input);

    }

}
