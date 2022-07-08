using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class click : MonoBehaviour
{
    public GameObject menu;
    public bool truth;

    private void Awake()
    {
        truth = false;
    }

    public void startup()
    {
        
        if (truth == false)
        {
            menu.SetActive(true);
            truth = true;
            
        }
        else if (truth == true)
        {
            menu.SetActive(false);
            truth = false;
        }
    }
    
}
