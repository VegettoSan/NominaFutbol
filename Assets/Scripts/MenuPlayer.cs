using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuPlayer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject Menu;

    private float clickTime = 0f;
    private float doubleClickTimeThreshold = 0.3f; // Threshold de tiempo para considerar como un doble clic


    void Start()
    {
        if (Menu != null)
        {
            Menu.SetActive(false);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if ((Time.time - clickTime) < doubleClickTimeThreshold)
            {
                // Doble clic derecho detectado
                Debug.Log("Doble clic derecho detectado en la imagen.");
                if (Menu != null)
                {
                    Menu.SetActive(true);
                }
            }
            else
            {
                // Primer clic derecho
                clickTime = Time.time;
            }
        }
    }
}