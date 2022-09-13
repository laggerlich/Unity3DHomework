using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{

    public GameObject myObjects; //массив объектов, изменяется в Юнити
    private float spawnLimitXLeft = -10; //создаете область спавна
    private float spawnLimitXRight = 10; //и задаете границы
    private float spawnPosY = 2;

    private void Start() //процедура генерации сцены (нулевой кадр)
    {
        StartCoroutine(Delay()); //инициализация таймера
    }

    IEnumerator Delay() //процедура инициализации задержки
    {
        yield return new WaitForSeconds(3); //задержка
        spawnRandomCylinder(); //процедура генерации объекта
    }

    void Update() //процедура покадрового обновления сцены
    {
        /*if (Input.GetKeyDown(KeyCode.Space)) //спавн объекта по кнопке
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 3), 1, Random.Range(-3, 3));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);

        }*/

        if (Input.GetKeyDown(KeyCode.RightShift)) //изменение размера по кнопке
        {
            transform.localScale = new Vector3(Random.Range(0.2f, 5.0f), 1, Random.Range(0.2f, 5.0f));
        }
    }
    void spawnRandomCylinder() //процедура генерации объекта
    {
        //int cylinderIndex = Random.Range(0, myObjects.Length);

        // Generate random ball index and random spawn position
        //Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        //Instantiate(myObjects[cylinderIndex], spawnPos, myObjects[0].transform.rotation);

        GameObject tmp = Instantiate(myObjects);
        tmp.transform.position = new Vector3(0.0f, tmp.transform.position.y, 0.0f);
    }
}
