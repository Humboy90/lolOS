using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class popup1 : MonoBehaviour
{
    public GameObject popup;
    public Canvas canvas;
    public IdentityItem idItem;
    public GameObject spawnedTab;


    // Update is called once per frame
    public void spawnpopup()
    {
        spawnedTab = GameObject.FindGameObjectWithTag("WIPTAB");
        if (spawnedTab == null)
        {
            Instantiate(popup, canvas.transform);

            spawnedTab = GameObject.FindGameObjectWithTag("WIPTAB");
            //spawnedTab.GetComponent<drag>().dragRectTransform.SetAsLastSibling();
            idItem.WIPtextUpdater(spawnedTab);
        }
        else
        {
            Destroy(spawnedTab);
            Instantiate(popup, canvas.transform);

            spawnedTab = GameObject.FindGameObjectWithTag("WIPTAB");
            //spawnedTab.GetComponent<drag>().dragRectTransform.SetAsLastSibling();
            idItem.WIPtextUpdater(spawnedTab);
        }
        
            
            
        
       

    }
}
