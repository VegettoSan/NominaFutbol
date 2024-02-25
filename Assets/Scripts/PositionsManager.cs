using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PositionsManager : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    [Space]
    public RectTransform[] Players;

    public GameObject C442, C433, C352, C532, C4231, C4312, C451, C343;
    [SerializeField] RectTransform[] P442, P433, P352, P532, P4231, P4312, P451, P343;

    void Start()
    {
        AssingPositions();

        // Agrega las opciones al dropdown
        List<string> options = new List<string> { "4-4-2", "4-3-3", "3-5-2", "5-3-2", "4-2-3-1", "4-3-1-2", "4-5-1", "3-4-3" };
        dropdown.AddOptions(options);

        // Establece la primera opción como predeterminada
        dropdown.value = 0;

        // Asigna funciones a cada opción
        dropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(dropdown); });

        // Ejecuta la función para la opción predeterminada
        DropdownValueChanged(dropdown);
    }

    // Función que se llama cuando se selecciona una opción
    void DropdownValueChanged(TMP_Dropdown change)
    {
        switch (change.value)
        {
            case 0:
                // Lógica para 4-4-2
                if (Players.Length != P442.Length)
                {
                    Debug.LogError("Los arrays de jugadores y posiciones deben tener la misma longitud.");
                    return;
                }
                for (int i = 0; i < Players.Length; i++)
                {
                    Players[i].localPosition = P442[i].localPosition;
                }

                break;
            case 1:
                // Lógica para 4-3-3
                if (Players.Length != P433.Length)
                {
                    Debug.LogError("Los arrays de jugadores y posiciones deben tener la misma longitud.");
                    return;
                }
                for (int i = 0; i < Players.Length; i++)
                {
                    Players[i].localPosition = P433[i].localPosition;
                }

                break;
            case 2:
                // Lógica para 3-5-2
                if (Players.Length != P352.Length)
                {
                    Debug.LogError("Los arrays de jugadores y posiciones deben tener la misma longitud.");
                    return;
                }
                for (int i = 0; i < Players.Length; i++)
                {
                    Players[i].localPosition = P352[i].localPosition;
                }

                break;
            case 3:
                // Lógica para 5-3-2
                if (Players.Length != P532.Length)
                {
                    Debug.LogError("Los arrays de jugadores y posiciones deben tener la misma longitud.");
                    return;
                }
                for (int i = 0; i < Players.Length; i++)
                {
                    Players[i].localPosition = P532[i].localPosition;
                }

                break;
            case 4:
                // Lógica para 4-2-3-1
                if (Players.Length != P4231.Length)
                {
                    Debug.LogError("Los arrays de jugadores y posiciones deben tener la misma longitud.");
                    return;
                }
                for (int i = 0; i < Players.Length; i++)
                {
                    Players[i].localPosition = P4231[i].localPosition;
                }

                break;
            case 5:
                // Lógica para 4-3-1-2
                if (Players.Length != P4312.Length)
                {
                    Debug.LogError("Los arrays de jugadores y posiciones deben tener la misma longitud.");
                    return;
                }
                for (int i = 0; i < Players.Length; i++)
                {
                    Players[i].localPosition = P4312[i].localPosition;
                }

                break;
            case 6:
                // Lógica para 4-5-1
                if (Players.Length != P451.Length)
                {
                    Debug.LogError("Los arrays de jugadores y posiciones deben tener la misma longitud.");
                    return;
                }
                for (int i = 0; i < Players.Length; i++)
                {
                    Players[i].localPosition = P451[i].localPosition;
                }

                break;
            case 7:
                // Lógica para 3-4-3
                if (Players.Length != P343.Length)
                {
                    Debug.LogError("Los arrays de jugadores y posiciones deben tener la misma longitud.");
                    return;
                }
                for (int i = 0; i < Players.Length; i++)
                {
                    Players[i].localPosition = P343[i].localPosition;
                }

                break;
            default:
                Debug.Log("Selección no reconocida");
                break;
        }
    }

    void AssingPositions()
    {
        P343 = GetChildRectTransforms(C343);
        P352 = GetChildRectTransforms(C352);
        P4231 = GetChildRectTransforms(C4231);
        P4312 = GetChildRectTransforms(C4312);
        P433 = GetChildRectTransforms(C433);
        P442 = GetChildRectTransforms(C442);
        P451 = GetChildRectTransforms(C451);
        P532 = GetChildRectTransforms(C532);
    }

    RectTransform[] GetChildRectTransforms(GameObject parent)
    {
        List<RectTransform> childRects = new List<RectTransform>();
        foreach (Transform child in parent.transform)
        {
            RectTransform rectTransform = child.GetComponent<RectTransform>();
            if (rectTransform != null)
            {
                childRects.Add(rectTransform);
            }
        }
        return childRects.ToArray();
    }
}