using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    [SerializeField] private Transform wallTransform;
    [SerializeField] private float wallSpeed;
    
    void Start()
    {
        
    }

    void Update()
    {
        wallTransform.position = new Vector3(wallTransform.position.x, wallTransform.position.y + wallSpeed, 0f);
    }
}
