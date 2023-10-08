using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff2 : MonoBehaviour
{
    [SerializeField] private Transform Origin;

    [SerializeField] private int timeToFlip;

    private int Ticks = -1;
    void Update()
    {
        Ticks++;
        if (Ticks == 0)
        {
            transform.position = new Vector2(Origin.position.x - 20000, Origin.position.y);
            Ticks = 0;
        }
        if (Ticks == timeToFlip/2)
        {
            transform.position = new Vector2(Origin.position.x, Origin.position.y);
        }
        if (Ticks == timeToFlip)
        {
            transform.position = new Vector2(Origin.position.x - 20000, Origin.position.y);
            Ticks = 0;
        }
    }
}
