using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedColor : MonoBehaviour
{
    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }*/
    }

    public void SetRed()
    {
        myObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
    }
}
