using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;


public class LevelManager : MonoBehaviour
{

    [SerializeField] int level = 1;
    [SerializeField] public float speed = 3;
     public int depth = 2000;

    private float baseSpeed = 6;
    private float timer = 0.0f;
    private float timelapse = 1.0f;
    private int distanceToLevelUp = 400;
    private int distanceLapse = 20;
    private GameObject player;
    private Light2D globalLight;

    public AudioClip backAudio;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        speed = 0.5f*baseSpeed;
        globalLight = GameObject.Find("GlobalLight2D").GetComponent<Light2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Every second
        timer += Time.deltaTime;
        if (timer > timelapse)
        {
            timer -= timelapse;
            depth -= distanceLapse;
            if (distanceToLevelUp == 0)
            {
                distanceToLevelUp = 400;
                level++;
                switch (level)
                {
                    case 5:
                        speed = 2f*baseSpeed;
                        globalLight.intensity = 10.75f;
                        break;
                    case 4:
                        globalLight.intensity = 10.75f;
                        break;
                    case 3:
                        globalLight.intensity = 8.3f;
                        break;
                    case 2:
                        speed = baseSpeed;
                        globalLight.intensity = 5f;
                        break;  
                }
            }
            distanceToLevelUp -= distanceLapse;
        }

        player.transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
