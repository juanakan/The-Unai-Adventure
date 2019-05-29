using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class pulsado : MonoBehaviour, IPointerDownHandler, IPointerUpHandler{
    public bool pulso;
    public void OnPointerDown(PointerEventData eventData)
    {
        pulso = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pulso = false;
    }
}
