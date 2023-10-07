using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RocketPlatform : MonoBehaviour
{
    [SerializeField] private Transform destination;
    [SerializeField] float ObjectSpeed;

    private float time = 0;
    private bool active = false;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            active = true;
        }
    }
    void Update()
    {
        if (active && time <= 1000) 
        {
            time += 1;
            transform.position = Vector3.MoveTowards(destination.position.x, destination.position.y, ObjectSpeed * Time.deltaTime);
        }
    }
}
