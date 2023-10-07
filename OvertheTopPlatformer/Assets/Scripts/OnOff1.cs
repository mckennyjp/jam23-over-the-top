using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff1 : MonoBehaviour
{
    [SerializeField] private Transform Origin;

    private int Ticks = 0;
    void Update()
    {
        Ticks++;
        if (Ticks == 2000) 
        {
            transform.position = new Vector2(Origin.position.x - 20000, 0);
        }
        if (Ticks == 4000) 
        {
            transform.position = new Vector2(Origin.position.x, 0);
            Ticks = 0;
        }
    }
}
