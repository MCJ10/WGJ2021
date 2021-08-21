using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Energy : MonoBehaviour
{
    public GameObject player;
    public Light point_light;



    // Start is called before the first frame update
    void Start()
    {
        // point_light = player.GetComponent<Light>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Energy");
        // Debug.Log(player.life);
        // player.transform.GetChild(0).Light.intensity = 0;
    }
}
