using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text txtScore;
    private int totScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        DisScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisScore(int score)
    {
        totScore += score;
        txtScore.text = "Bag:<color=#ff0000>" + totScore.ToString() + "</color>";
    }
}
