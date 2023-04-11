using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskbarSettings : MonoBehaviour
{
    public GameObject taskbar;
    public GameObject canvas;
    

    // Update is called once per frame
    void Update()
    {
        if (taskbar == null)
        {
            taskbar = GameObject.FindGameObjectWithTag("taskbar");
        }
        if (canvas == null)
        {
            canvas = GameObject.FindGameObjectWithTag("canvas");
        }

    }

    public void Windows11Normal()
    {
        taskbar.GetComponent<RectTransform>().position = new Vector3(canvas.transform.position.x, 58, 0);
    }
    public void ResetTaskbar()
    {
        taskbar.GetComponent<RectTransform>().position = new Vector3(canvas.transform.position.x, 15, 0);
    }
}
