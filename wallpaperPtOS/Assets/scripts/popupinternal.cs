using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupinternal : MonoBehaviour
{
    public GameObject hometab;
    public GameObject newtab;
    public void OpenTab()
    {
        hometab.SetActive(false);
        newtab.SetActive(true);

    }
}
