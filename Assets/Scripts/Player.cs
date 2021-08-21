using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Player : MonoBehaviour
{
    public float ms = 6;
    public int life = 3;
    
    private float radiusIntensity = 1;
    private Light2D point_light; 
    // Start is called before the first frame update
    void Start()
    {
        point_light = GetComponentInChildren<Light2D>();
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

        radiusIntensity = radiusIntensity - 0.008f;
        // point_light.pointLightInnerRadius = point_light.pointLightInnerRadius * radiusIntensity;
        point_light.intensity = point_light.intensity*radiusIntensity;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("triggering collider !! ");
        Debug.Log(point_light.intensity);
        // transform.GetChild(0).intensity = 0;
        // GetComponentInChildren<Light2D>().pointLightInnerRadius = GetComponentInChildren<Light2D>().pointLightInnerRadius - 1;

        
    }

    
}
