using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NumberOfKey : MonoBehaviour {
    public Text scoreLabel;
    public string itemName;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected:" + itemName);
        Destroy(this.gameObject);
       
    }
    void Start()
    {
        float scoreLabel = 0f;
    }
    void Update()
    {
        scoreLabel = "1";
    }
   
}
