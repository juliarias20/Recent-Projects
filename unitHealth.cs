using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitHealth
{

    //Fields
    int _currentHealth;
    int _currentMaxHealth;


    //Properties
    public int Health
    {
        get
        {
            return _currentHealth;
        }

        set
        {
            _currentHealth = value;
        }
    }


    public int MaxHealth
    {
        get
        {
            return _currentMaxHealth;
        }

        set
        {
            _currentMaxHealth = value;
        }
    }



    //Constructor
    public unitHealth(int health, int maxHealth)
    {
        _currentHealth = health;
        _currentMaxHealth = maxHealth;

    }


    //Methods
    public void dmgUnit(int dmgAmount)
    {
        if (_currentHealth > 0)
        {
            _currentHealth -= dmgAmount;
        }
    }

    public void healUnit(int healAmount)
    {
        if (_currentHealth < _currentMaxHealth)
        {
            _currentHealth += healAmount;
        }
    }
}
