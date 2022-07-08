using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimizemax : MonoBehaviour
{
    public GameObject tab;
    public bool tof = false;
    public void minimize()
    {
        Debug.Log("eee");
        if(tof == true)
        {
            tof = false;
            tab.SetActive(false);
            Debug.Log("eee2");
        }
        else
        {
            Debug.Log("eee3");
            tof = true;
            tab.SetActive(true);
        }
        
    }


}
