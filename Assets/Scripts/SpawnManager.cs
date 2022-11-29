using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    private int spawnRangeZ = 10;
    private int spawnRangeX = 20;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.5f, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(spawnPrefabs[0], randomPos, gameObject.transform.rotation);
        randomPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.5f, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(spawnPrefabs[1], randomPos, gameObject.transform.rotation);
        randomPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.5f, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(spawnPrefabs[2], randomPos, gameObject.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
    }

}
