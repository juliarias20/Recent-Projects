using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    // Fields
    int currentHealth;
    int currentMaxhealth;

    //Properties
    public int PlayerHealth
    {
        get
        {
            return currentHealth;
        }

        set
        {
            currentHealth = value;
        }
    }

    public int MaxHealth
    {
        get
        {
            return currentMaxhealth;
        }

        set
        {
            currentMaxhealth = value;
        }
    }


    // Constructor
    public Health(int health, int maxHealth)
    {
        currentHealth = health;
        currentHealth = maxHealth;
    }


    //Methods
    public void DmgUnit(int dmgAmount)
    {
        if (currentHealth > 0)
        {
            currentHealth -= dmgAmount;
        }
    }

    public void HealUnit(int healAmount)
    {
        if (currentHealth < currentMaxhealth)
        {
            currentHealth -= healAmount;
        }

        if (currentHealth > currentMaxhealth)
        {
            currentHealth = currentMaxhealth;
        }
    }

}