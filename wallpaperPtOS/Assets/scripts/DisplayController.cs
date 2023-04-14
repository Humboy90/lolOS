using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    public Text displayText;
    public Calculator calculator;

    void Start()
    {

    }

    public void ClearDisplay()
    {
        displayText.text = "";
    }

    public void UpdateDisplayText(string newText)
    {
        displayText.text += newText;
    }

    public void DisplayAnswer()
    {
        string answer = "";
        displayText.text = answer;
    }
}
