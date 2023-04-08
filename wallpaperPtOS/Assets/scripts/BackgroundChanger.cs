using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundChanger : MonoBehaviour
{
    public GameObject background;
    public Sprite newbackround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(background == null)
        {
            background = GameObject.FindGameObjectWithTag("background");
        }

    }

    public void ChangeBackground()
    {
        background.GetComponent<Image>().sprite = newbackround;
    }
}
