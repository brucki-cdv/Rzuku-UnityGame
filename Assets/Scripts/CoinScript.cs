using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioClip coinSound;
    public float musicVolume;
    void Start()
    {
        ScoreTextScript.coinAmount = 0;
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        AudioSource.PlayClipAtPoint(coinSound, transform.position, 1 );
        ScoreTextScript.coinAmount += 10;
        Destroy(gameObject);
    }
}
