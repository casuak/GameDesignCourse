using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorebtn : MonoBehaviour
{
    private GameUI gameUI;

    public void OnClickScoreBtn()
    {
        gameUI.DisScore(1);
    }
    // Start is called before the first frame update
    void Start()
    {
        gameUI = GameObject.Find("GameUI").GetComponent<GameUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
