using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour
{
    public GameObject cylinder; //объект, который мы будем спавнить
    float time = 3f; //задержка
    bool flag = false; //флаг первого выполннеия

    private void Start() 
    {
        
    }

    void Update() //процедура покадрового обновления сцены
    {
        time -= Time.deltaTime; //обратный отсчет
        if (time <= 0 && flag == false)
        {
            GameObject tmp = Instantiate(cylinder);
            tmp.transform.position = new Vector3(0.0f, tmp.transform.position.y, 0.0f); //спавн
            flag = true; //исключение повторного появления
        }

    }
}
