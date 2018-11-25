using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NumberOfKey : MonoBehaviour
{
    public Text scoreLabel;
    public string itemName;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected:" + itemName);
        Destroy(this.gameObject);
        if (itemName == "key")
        {
            PlayerCharacter player = other.GetComponent<PlayerCharacter>();
            if (player != null)
            {
                player.ChangeKey(1);
            }
        }

    }

}
