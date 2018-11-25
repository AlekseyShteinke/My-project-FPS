using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour {
    private int _health;
    private int maxHealth;

    private int count;
    public Text scoreLabel;

    // Use this for initialization
    void Start () {
        _health = 50;
        maxHealth = 100;
        count = 0;
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

    public void ChangeKey(int value)
    {
        count += value;
        Debug.Log("Key:" + count);
    }

    private void OnGUI()
    {
        scoreLabel.text = "" + count.ToString();
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
