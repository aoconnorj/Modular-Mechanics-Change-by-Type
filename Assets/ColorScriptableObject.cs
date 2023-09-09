using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu]
public class ColorScriptableObject : ScriptableObject
{

        public string initValue;
        public string value;

        private void OnEnable()
        {
            value = initValue;
        }

}
