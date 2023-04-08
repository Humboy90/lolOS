using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupinternal : MonoBehaviour
{
    public GameObject hometab;
    public GameObject newtab;
    public bool boolean = false;
    public void OpenTab()
    {
        hometab.SetActive(false);
        newtab.SetActive(true);

    }
    public void SettingsTab()
    {
        if (boolean == false)
        {
            newtab.SetActive(true);
            boolean = true;
        }
        else if (boolean == true)
        {
            newtab.SetActive(false);
            boolean = false;
        }

    }
}
