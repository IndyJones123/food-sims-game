using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public int maxHealth = 100;  // the player's maximum health
    public int currentHealth;  // the player's current health
    public bool isDead;  // flag indicating whether the player is dead

    public Image healthBar;

    void Start()
    {
        currentHealth = maxHealth;  // set the player's starting health to their maximum health
        isDead = false;  // the player is not dead at the start of the game


    }

    public void TakeDamage(int damageAmount)
    {
        if (isDead) return;  // if the player is already dead, don't take any damage

        currentHealth -= damageAmount;  // subtract the damage amount from the player's health

        if (currentHealth <= 0)
        {
            isDead = true;  // the player is now dead
            Die();  // call the Die() function to handle the player's death
        }
    }

    void Die()
    {
        // add any death-related logic here, such as playing an animation or respawning the player
    }
}