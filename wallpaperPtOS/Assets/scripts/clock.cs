using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
public class clock : MonoBehaviour
{
    public DateTime dateTime;
    public TextMeshProUGUI hour, minute;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hour.text = dateTime.Hour.ToString();        
        if(dateTime.Minute < 10)
        {
            minute.text = "0" + dateTime.Minute.ToString();
        }
        else
        {
            minute.text = dateTime.Minute.ToString();
        }

        dateTime = DateTime.Now;
        
    }
}
