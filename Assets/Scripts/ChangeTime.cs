using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTime : MonoBehaviour
{
    int N = 1;

    public RectTransform[] Team1;
    public RectTransform[] Team2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (N == 1)
            {
                N = 2;
            }
            if (N == 2)
            {
                N = 1;
            }

            ChangePositionTeam1();
            ChangePositionTeam2();
        }
    }

    void ChangePositionTeam1()
    {
        foreach(RectTransform r in Team1)
        {
            r.localPosition = new Vector3(-r.localPosition.x, r.localPosition.y, r.localPosition.z);
            /*if(N == 1)
            {
                r.localPosition = new Vector3(-r.localPosition.x, r.localPosition.y, r.localPosition.z);
            }
            if (N == 2)
            {
                r.localPosition = new Vector3(r.localPosition.x, r.localPosition.y, r.localPosition.z);
            }*/
        }
    }
    void ChangePositionTeam2()
    {
        foreach (RectTransform r in Team2)
        {
            r.localPosition = new Vector3(-r.localPosition.x, r.localPosition.y, r.localPosition.z);
            /*if (N == 1)
            {
                r.localPosition = new Vector3(r.localPosition.x, r.localPosition.y, r.localPosition.z);
            }
            if (N == 2)
            {
                r.localPosition = new Vector3(-r.localPosition.x, r.localPosition.y, r.localPosition.z);
            }*/
        }
    }
}
