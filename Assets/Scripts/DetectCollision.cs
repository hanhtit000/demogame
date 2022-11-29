using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public Material[] gameMaterial;
    private int spawnRangeZ = 10;
    private int spawnRangeX = 20;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
       gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        Renderer renderer1 = gameObject.GetComponent<Renderer>();
        Renderer renderer2 = other.gameObject.GetComponent<Renderer>();
        if (renderer1.material.color.Equals(renderer2.material.color))
        {
            StartCoroutine(Respawn(0, 1, other));
            int i = Random.Range(0, gameMaterial.Length);
            renderer1.material = gameMaterial[i];
            gm.UpdateScore(1);
        }
    }
    IEnumerator Respawn(float timeToDespawn, float timeToRespawn, Collider other)
    {
        yield return new WaitForSeconds(timeToDespawn);
        other.gameObject.SetActive(false);
        yield return new WaitForSeconds(timeToRespawn);
        other.gameObject.transform.position = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.5f, Random.Range(-spawnRangeZ, spawnRangeZ));
        other.gameObject.SetActive(true);
    }
}
