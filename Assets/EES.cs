using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//easyenemySpawn
public class EES : MonoBehaviour
{
    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        // enemies will spawn after 2 seconds and repeat spawning at a random interval after between 2 and 10
        InvokeRepeating("SpawnEE", 2, Random.Range(2, 10));

    }

    Vector3 getRandomSmallPos()
    {
        float x = Random.Range(71, 95);
        float y = 0.89f;
        float z = Random.Range(4, 90);

        Vector3 newSmallPos = new Vector3(x, y, z);
        return newSmallPos;

    }

    void SpawnEE()
    {
        Instantiate(enemies[Random.Range(0, 2)], getRandomSmallPos(), Quaternion.identity);
    }

}


