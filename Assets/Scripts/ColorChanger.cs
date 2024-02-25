using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorChanger : MonoBehaviour
{
    public Image image; // Referencia al componente Image
    public TMP_Text text1, text2; // Referencia al componente TMP_Text


    // Método para cambiar el color del texto
    void ChangeTextColor()
    {
        // Obtener el color del Image
        Color imageColor = image.color;

        // Calcular la luminancia del color del Image
        float luminance = (0.2126f * imageColor.r + 0.7152f * imageColor.g + 0.0722f * imageColor.b);

        // Determinar si el color del Image es claro u oscuro (usando un umbral de 0.5)
        if (luminance > 0.5f)
        {
            // Si es claro, establecer el color del texto en negro
            text1.color = Color.black;
            text2.color = Color.black;
        }
        else
        {
            // Si es oscuro, establecer el color del texto en blanco
            text1.color = Color.white;
            text2.color = Color.white;
        }
    }

    // Método de inicio
    void Start()
    {
        // Llamar al método para cambiar el color del texto al iniciar
        ChangeTextColor();
    }

    void LateUpdate()
    {
        ChangeTextColor();
    }
}