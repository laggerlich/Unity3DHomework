using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    //public float speed = 2;
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }
}
