using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher : MonoBehaviour
{
    [SerializeField] Transform crusherTransform;
    [SerializeField] Transform wallTransform;

    private float speed = -0.3f;
    
    void Update()
    {
        if(wallTransform.position.y > crusherTransform.position.y){
            crusherTransform.position = new Vector2(0,crusherTransform.position.y + speed);
        }
    }
}
