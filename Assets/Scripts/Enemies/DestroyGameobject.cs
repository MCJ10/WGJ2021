using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameobject : MonoBehaviour
{
    // Start is called before the first frame update
  
    private float sideBoud = 20;
    public Transform player;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       


       if (transform.position.y < player.position.y -20)
        {
        
            Destroy(gameObject);

           




        }

        if (transform.position.x > sideBoud)
        {
       
            Destroy(gameObject);
           

        }
        if (transform.position.x < -sideBoud)
        {
           
            Destroy(gameObject);
          


        }

    }
}

