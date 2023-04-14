using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textWrite : MonoBehaviour
{
    string inputString = "";
    int lengthOfField = 30;

    public void OnGUI()
    {
        inputString = GUILayout.TextField(inputString, lengthOfField);
    }
}
