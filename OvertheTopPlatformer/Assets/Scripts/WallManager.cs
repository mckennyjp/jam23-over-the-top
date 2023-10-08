using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class WallManager : MonoBehaviour
{
    [SerializeField] private Transform wallTransform;
    [SerializeField] private float wallSpeed;

    void FixedUpdate()
    {
        wallTransform.position = new Vector3(wallTransform.position.x, wallTransform.position.y + wallSpeed, 0f);
    }
}
