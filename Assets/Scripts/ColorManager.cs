using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{
    [Header("EQUIPO 1")]
    public Color Color_1;
    public ColorPicker Pick_1;
    public Image[] Images_1;

    [Header("EQUIPO 1")]
    public Color Color_2;
    public ColorPicker Pick_2;
    public Image[] Images_2;

    public void ChangeColor_1()
    {
        Color_1 = Pick_1.output;
        ChangeColorImages(Images_1, Color_1);
    }
    public void ChangeColor_2()
    {
        Color_2 = Pick_2.output;
        ChangeColorImages(Images_2, Color_2);
    }

    void ChangeColorImages(Image[] images, Color C)
    {
        foreach(Image img in images)
        {
            img.color = C;
        }
    }
}
