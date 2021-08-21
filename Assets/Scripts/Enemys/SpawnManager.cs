using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] FishsMesopelagicaZone;

    

    public float randomRangeX;
    public Transform target;

    
    private float startDelay = 2;
    private float spawnInterval = 1.5f;





    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnFishMesopelagicaZone", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void spawnFishMesopelagicaZone()
    {
        UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(UnityEngine.Random.Range(-randomRangeX, randomRangeX), target.transform.position.y + 10, 0);
        int animalIndex = UnityEngine.Random.Range(0, FishsMesopelagicaZone.Length);

        Instantiate(FishsMesopelagicaZone[animalIndex], spawnPos, FishsMesopelagicaZone[animalIndex].transform.rotation);



    }
}
