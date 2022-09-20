using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlledSpawn : MonoBehaviour
{
    public GameObject[] myObj;
    float delay = 0;

    private float spawnLimitXLeft = -10; //создаете область спавна
    private float spawnLimitXRight = 10; //и задаете границы
    private float spawnPosY = 2;

    bool spawnFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetButtonDown("Start spawn"))
        if(Input.GetButtonDown("StartSpawn"))
        {
            spawnFlag = true;
        }*/

        if(spawnFlag == true && delay<=0)
        {
            fluentSpawn();
            delay = 2;
        }

        /*if(Input.GetButtonDown("StopSpawn"))
        {
            spawnFlag = false;
        }*/

        delay -= Time.deltaTime;
    }

    void fluentSpawn()
    {
        int objIndex = Random.Range(0, myObj.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, Random.Range(-3, 1));

        // instantiate ball at random spawn location
        Instantiate(myObj[objIndex], spawnPos, myObj[0].transform.rotation);
        //myObj[objIndex].GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    public void spawnSwitch()
    {
        spawnFlag = !(spawnFlag);
    }

    public void spawnOn()
    {
        spawnFlag = true;
    }

    public void spawnOff()
    {
        spawnFlag = false;
    }
}
