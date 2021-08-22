using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Player : MonoBehaviour
{
    public float ms = 6;
    public int life = 3;
    
    private float timer = 0.0f;
    private float timeToFade = 1.0f;
    private float timeToShine = 20.0f;
    private float timeToPower = 2.0f;
    private float initialRadius;
    private Light2D point_light; 

    // Start is called before the first frame update
    void Start()
    {
        point_light = GetComponentInChildren<Light2D>();
        initialRadius = point_light.pointLightOuterRadius;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * ms * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * ms * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * ms * Time.deltaTime);
        }

        timer += Time.deltaTime;
        if (timer > timeToFade)
        {
            timer = timer - timeToFade;
            point_light.pointLightOuterRadius = point_light.pointLightOuterRadius - initialRadius/timeToShine;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Alga")
        {
            point_light.pointLightOuterRadius = Mathf.Clamp(point_light.pointLightOuterRadius + initialRadius/timeToPower, 0, initialRadius);
            Destroy(other.gameObject);
        }
        
    }

    
}
