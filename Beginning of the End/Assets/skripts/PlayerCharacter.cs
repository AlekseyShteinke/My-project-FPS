using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {
    private int _health;
    private int maxHealth;


	// Use this for initialization
	void Start () {
        _health = 50;
        maxHealth = 100;
	}

    public void ChangeHealth(int value)
    {
        _health += value;
        if(_health > maxHealth)
        {
            _health = maxHealth;
        } else if (_health < 0)
        {
            _health = 0;
        }

        Debug.Log("health:" + _health + "/" + maxHealth);

    }

	
	// Update is called once per frame
	void Update () {
		
	}

    public void Hurt(int damage)
    {
        _health -= damage;
        Debug.Log("Health" + _health);
    }

}
