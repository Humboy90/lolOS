using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugOut : MonoBehaviour
{
    public void debugLog()
    {
        Debug.Log("Im Working! : " + this.name.ToString());
    }
}
