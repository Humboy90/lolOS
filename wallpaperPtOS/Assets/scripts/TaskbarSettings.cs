using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskbarSettings : MonoBehaviour
{
    public GameObject taskbar;
    

    // Update is called once per frame
    void Update()
    {
        if (taskbar == null)
        {
            taskbar = GameObject.FindGameObjectWithTag("taskbar");
        }

    }

    public void Windows11Normal()
    {
        taskbar.GetComponent<RectTransform>().position = new Vector3(551.5f, 58, 0);
    }
    public void ResetTaskbar()
    {
        taskbar.GetComponent<RectTransform>().position = new Vector3(551.5f, 15, 0);
    }
}
