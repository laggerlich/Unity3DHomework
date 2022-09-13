using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rescaling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightShift)) //изменение размера по кнопке
        {
            transform.localScale = new Vector3(Random.Range(0.2f, 5.0f), 1, Random.Range(0.2f, 5.0f));
        }
    }
}
