using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class popup1 : MonoBehaviour
{
    public GameObject popup;
    public Canvas canvas;

    // Update is called once per frame
    public void spawnpopup()
    {
       Instantiate(popup,canvas.transform);
       popup.GetComponent<drag>().dragRectTransform.SetAsLastSibling();
       

    }
}
