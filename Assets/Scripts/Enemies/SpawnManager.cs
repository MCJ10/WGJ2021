using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] FishsMesopelagicaZone;
    public GameObject[] FishLvl2;
    public GameObject[] FishLvl3;
    public GameObject[] FishLvl4;
    public GameObject[] Energy;

    private LevelManager LvlManager;

    public float randomRangeX;
    public Transform target;


    private float startDelay = 1;
    private float spawnInterval = 3;

    private float timer = 0.0f;
    private float timelapse = 3.0f;



    // Start is called before the first frame updateS
    void Start()
    {


        LvlManager = FindObjectOfType<LevelManager>();


        


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        timer += Time.deltaTime;
        if (timer > timelapse)
        {
            timer -= timelapse;

            if (LvlManager.depth <= 2000 && LvlManager.depth >=1600)
            {
                Invoke("spawnFishMesopelagicaZone", startDelay);
                Invoke ("spawnEnergy", startDelay);

            }
            else if (LvlManager.depth <= 1599 && LvlManager.depth >= 1200)
            {
                Invoke("spawnLvl2Zone", startDelay);
                Invoke("spawnEnergy", startDelay);
                timelapse = 2.7f;
            }

            else if (LvlManager.depth <= 1199 && LvlManager.depth >= 800)
            {
                Invoke("spawnLvl3Zone", startDelay);
                timelapse = 2f;
            }

            else if (LvlManager.depth <= 799 && LvlManager.depth >= 400)
            {
                Invoke("spawnLvl4Zone", startDelay);
                timelapse = 1f;
            }

        }







    }





    public void spawnFishMesopelagicaZone()
    {
        UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(UnityEngine.Random.Range(-randomRangeX, randomRangeX), target.transform.position.y + 20, 0);
        int animalIndex = UnityEngine.Random.Range(0, FishsMesopelagicaZone.Length);

        Instantiate(FishsMesopelagicaZone[animalIndex], spawnPos, FishsMesopelagicaZone[animalIndex].transform.rotation);
    }
    public void spawnEnergy()
    {
        UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(UnityEngine.Random.Range(-randomRangeX, randomRangeX), target.transform.position.y + 20, 0);
        int energyIndex = UnityEngine.Random.Range(0, Energy.Length);

        Instantiate(Energy[energyIndex], spawnPos, Energy[energyIndex].transform.rotation);
    }

    public void spawnLvl2Zone()
    {
        UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(UnityEngine.Random.Range(-randomRangeX, randomRangeX), target.transform.position.y + 20, 0);
        int animalIndex = UnityEngine.Random.Range(0, FishLvl2.Length);

        Instantiate(FishLvl2[animalIndex], spawnPos, FishLvl2[animalIndex].transform.rotation);
    }

    public void spawnLvl3Zone()
    {
        UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(UnityEngine.Random.Range(-randomRangeX, randomRangeX), target.transform.position.y + 20, 0);
        int animalIndex = UnityEngine.Random.Range(0, FishLvl3.Length);

        Instantiate(FishLvl3[animalIndex], spawnPos, FishLvl3[animalIndex].transform.rotation);
    }
    public void spawnLvl4Zone()
    {
        UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(UnityEngine.Random.Range(-randomRangeX, randomRangeX), target.transform.position.y + 20, 0);
        int animalIndex = UnityEngine.Random.Range(0, FishLvl4.Length);

        Instantiate(FishLvl4[animalIndex], spawnPos, FishLvl4[animalIndex].transform.rotation);
    }
}
