using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closewindow : MonoBehaviour
{
    public GameObject popup;
    
    public void close()
    {
        Destroy(popup);
    }
}
