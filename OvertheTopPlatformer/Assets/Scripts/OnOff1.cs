using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff1 : MonoBehaviour
{
    [SerializeField] private Transform Origin;
    
    [SerializeField] private int timeToFlip;

    private int Ticks = 0;
    void Update()
    {
        Ticks++;
        if (Ticks == timeToFlip / 2) 
        {
            transform.position = new Vector2(Origin.position.x - 20000, Origin.position.y);
        }
        if (Ticks == timeToFlip) 
        {
            transform.position = new Vector2(Origin.position.x, Origin.position.y);
            Ticks = 0;
        }
    }
}
