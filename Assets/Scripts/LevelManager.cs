using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    [SerializeField] int level = 1;
    [SerializeField] public float speed = 3;
    [SerializeField] int depth = 2000;

    private float baseSpeed = 6;
    private float timer = 0.0f;
    private float timelapse = 1.0f;
    private int distanceToLevelUp = 400;
    private int distanceLapse = 20;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        speed = 0.5f*baseSpeed;
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
                        break;
                    default:
                        speed = baseSpeed;
                        break;
                }
            }
            distanceToLevelUp -= distanceLapse;
        }

        player.transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
