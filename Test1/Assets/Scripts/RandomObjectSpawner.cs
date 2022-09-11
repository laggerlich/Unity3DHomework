using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{

    public GameObject[] myObjects;
    private float spawnLimitXLeft = -10;
    private float spawnLimitXRight = 10;
    private float spawnPosY = 2;

    private void Start()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(3);
        spawnRandomCylinder();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 3), 1, Random.Range(-3, 3));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);

        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            transform.localScale = new Vector3(Random.Range(0.2f, 5.0f), 1, Random.Range(0.2f, 5.0f));
        }
    }
    void spawnRandomCylinder()
    {
        int cylinderIndex = Random.Range(0, myObjects.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(myObjects[cylinderIndex], spawnPos, myObjects[0].transform.rotation);
    }
}
