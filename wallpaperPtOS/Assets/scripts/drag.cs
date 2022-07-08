using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class drag : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    /// <summary>
    /// import  IBeginDragHandler,IEndDragHandler for transparency
    /// </summary>
    [SerializeField] public RectTransform dragRectTransform;
    [SerializeField] private Canvas canvas;
    [SerializeField] private Image bgImage;
    private Color bgColor;

    private void Awake()
    {
        bgColor = bgImage.color;

        if(canvas == null)
        {
            Transform testCanvasTransform = transform.parent;
            while (testCanvasTransform != null)
            {
                canvas = testCanvasTransform.GetComponent<Canvas>();
                if(canvas != null)
                {
                    break;
                }
                testCanvasTransform = testCanvasTransform.parent;
            }
        }
    }

    /// option : transparency/ ligtening
    /*
    public void OnBeginDrag(PointerEventData eventData)
    {
        bgColor.a = .4f;
        bgImage.color = bgColor;
    }
    /// option : transparency/ ligtening
    public void OnEndDrag(PointerEventData eventData)
    {
        bgColor.a = .1f;
        bgImage.color = bgColor;
    }
    */
    public void OnDrag(PointerEventData eventData)
    {
        dragRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }   

    public void OnPointerDown(PointerEventData eventData)
    {
            dragRectTransform.SetAsLastSibling();
    }
}
