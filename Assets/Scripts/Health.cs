using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth;
    
    public GameOver gameoverScreen;

    [SerializeField]
    private int currentHealth;

    private UnityEngine.Object explosionRef;



    void Start()
    {
        currentHealth = maxHealth;
        explosionRef = Resources.Load("Explosion");
    }

    // Update is called once per frame

    public void DamageCharacter(int damage)
    {
        FindObjectOfType<AudioManager>().Play("Hit");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            gameoverScreen.Setup();
            gameObject.SetActive(false);
        }

    }

    public void UpdateMaxhealth(int newMaxHealth)
    {
        maxHealth = newMaxHealth;
        currentHealth = maxHealth;

    }

}
