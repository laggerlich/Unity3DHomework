using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndMove : MonoBehaviour
{
    public GameObject[] myCylinder;

    private float spawnLimitXLeft = -10;
    private float spawnLimitXRight = 10;
    private float spawnPosY = 2;

    private float startDelay = 2.0f;
    //private float spawnInterval;
    private float targetTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(10);
        spawnRandomCylinder();

    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            transform.localScale = new Vector3(Random.Range(0.2f, 5.0f), 1, Random.Range(0.2f, 5.0f));
        }
    }

    void spawnRandomCylinder()
    {
        int cylinderIndex = Random.Range(0, myCylinder.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(myCylinder[cylinderIndex], spawnPos, myCylinder[0].transform.rotation);
    }
}
