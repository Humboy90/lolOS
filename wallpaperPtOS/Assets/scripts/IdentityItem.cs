using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdentityItem : MonoBehaviour
{
    public GameObject gameObj;
    public string version;

    // Start is called before the first frame update
    

    // Update is called once per frame
    public void WIPtextUpdater(GameObject popup)
    {
        Debug.Log(popup.name);
        popup.transform.FindChild("version").GetComponent<Text>().text = gameObj.name + " - v" + version;
    }
}
