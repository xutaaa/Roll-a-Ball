using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{

    public int score = 0;
    //es aris unity-shi chashenebuli funqcia romlitac unda davwerot UI-s score (qvemot)
    public Text scoreText;
    public Text resultText;
    public GameObject menu;
    public PlayerMover myMover;
    public Rigidbody myBody;

    public string winString;
    public string loseString;


    int targetScore;

    void Start()
    {
        targetScore = GameObject.FindGameObjectsWithTag("Coin").Length;
        

    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision" + col.gameObject.name);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            score = score + 1;
        }
        //else if (other.tag == "BadCoin" && score > 0)
        //{
        //    score = score - 1;
        //}
        //score = score + 1;

        else if (other.tag == "BadCoin")
        {
            GameOver(false);     
        }
        //Debug.Log("Triggered" + score + " " + other.gameObject.name);

        scoreText.text = "Score: " + score;
        Destroy(other.gameObject);


        if (targetScore == score)
        {
            GameOver(true);
        
        }


    }
    void GameOver(bool didWin)
    {
        menu.SetActive(true);
        myMover.enabled = false;
        myBody.isKinematic = true;

        if (didWin)
        {
            resultText.text = winString;
        }
        else
        {
            resultText.text = loseString;
        }
    }

  

    
}
