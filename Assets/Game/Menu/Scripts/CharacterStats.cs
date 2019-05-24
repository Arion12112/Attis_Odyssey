using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    // Start is called before the first frame update
    public Stat damage;
    public Stat armor;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(100);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(transform.name + "takes" + damage + "damage.");
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Lose");
            //Die();
        }
    }

    
}
