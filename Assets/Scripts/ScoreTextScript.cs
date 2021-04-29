using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreTextScript : MonoBehaviour
{
    Text text;
    public static int coinAmount;
    void Start()
    {
        text = GetComponent<Text>();
        text.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();
    }
}
