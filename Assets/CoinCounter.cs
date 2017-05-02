using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinCounter : MonoBehaviour {

    public int score = 0;
    //es aris unity-shi chashenebuli funqcia romlitac unda davwerot UI-s score (qvemot)
    public Text scoreText;

    void OnCollisionEnter (Collision col)
    {
        Debug.Log("Collision" + col.gameObject.name);
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Coin")
        {
            score = score + 1;
        }
        else if (other.tag == "BadCoin" && score > 0)
        {
            score = score - 1;
        }
        //score = score + 1;
        Debug.Log("Triggered" + score + " " + other.gameObject.name);

        Destroy(other.gameObject);

        scoreText.text = "Score: " + score;
    }
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
