using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enemySpawn
public class ES : MonoBehaviour
{
    public GameObject[] enemiesToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        // enemies will spawn after 5 seconds and repeat spawning at a random interval after between 4 and 10
        InvokeRepeating("SpawnNow", 5, Random.Range(4, 10));

    }

    Vector3 getRandomPos()
    {
        float x = Random.Range(5, 190);
        float y = 0.9f;
        float z = Random.Range(4, 194);

        Vector3 newPos = new Vector3(x, y, z);
        return newPos;

    }

    void SpawnNow()
    {
        Instantiate(enemiesToSpawn[Random.Range(0, 2)], getRandomPos(), Quaternion.identity);
    }

}


