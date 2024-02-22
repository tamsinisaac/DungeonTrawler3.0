using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DS : MonoBehaviour
{
    public GameObject[] gemToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNow", 5, 0);
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
        Instantiate(gemToSpawn[Random.Range(0, 1)], getRandomPos(), Quaternion.identity);
    }
}
