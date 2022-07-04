using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    ScoreManager _scoreManager;

    private void Awake() {
        _scoreManager = GameObject.Find("ScoreManagerText").GetComponent<ScoreManager>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            _scoreManager.IncrementScore();
        }
    }
}
