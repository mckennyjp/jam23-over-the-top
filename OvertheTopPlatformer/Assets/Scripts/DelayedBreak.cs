using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DelayedBreak : MonoBehaviour
{
    private int durability = 500;
    private bool breaking = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            breaking = true;
        }
    }

    private void Update()
    {
        if (breaking) 
        {
            durability -= 1;
        }
        if (durability == 0) 
        { 
            Destroy(gameObject);
        }
    }
}
