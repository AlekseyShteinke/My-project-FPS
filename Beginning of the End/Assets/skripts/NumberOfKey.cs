using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NumberOfKey : MonoBehaviour {
    public Text scoreLabel;
    public string itemName;
    private int count;
    void Start ()
    {
        count = 0;
        SetScoreLabel ();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected:" + itemName);
        Destroy(this.gameObject);
        count = count + 1;
        SetScoreLabel ();
    }
    void SetScoreLabel ()
    {
        scoreLabel.text = "" + count.ToString ();
    }
}
