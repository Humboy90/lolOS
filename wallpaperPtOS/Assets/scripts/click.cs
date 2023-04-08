using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Animations;
public class click : MonoBehaviour
{
    public GameObject menu;
    public bool truth;
    public Button Text;
    public Animator ani;
    public AnimationClip ani2;
    public Canvas yourcanvas;
    public float timer;

    void Start()
    {
        Text = Text.GetComponent<Button>();
        yourcanvas.enabled = true;
    }

    private void Awake()
    {
        truth = true;

    }

    public void Update()
    {
        
    }

    
    public void Press()
    {
        if (truth == true)
        {
            ani.Play("startmenu");
            truth = false;

        }
        else
        {
            ani.Play("startmenuclose");
            truth = true;
        }
        
    }

}
