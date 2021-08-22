using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    [SerializeField]
    private int currentHealth;

    private UnityEngine.Object explosionRef;

    public GameOver gameoverScreen;

    void Start()
    {
        currentHealth = maxHealth;
        explosionRef = Resources.Load("Explosion");
    }

    // Update is called once per frame

    public void DamageCharacter(int damage)
    {

        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
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
