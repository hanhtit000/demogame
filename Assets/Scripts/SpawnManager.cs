using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    private int spawnRangeZ = 9;
    private int spawnRangeX = 20;
    private GameManager gm;
    private bool spawned=false;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.isAvtive == true && spawned==false)
        {
            spawned = true;
            Vector3 randomPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.5f, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(spawnPrefabs[0], randomPos, gameObject.transform.rotation);
            randomPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.5f, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(spawnPrefabs[1], randomPos, gameObject.transform.rotation);
            randomPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.5f, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(spawnPrefabs[2], randomPos, gameObject.transform.rotation);
        }
    }

}
