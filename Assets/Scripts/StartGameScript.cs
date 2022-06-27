using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public float sceneSwitchTime = 5.0f;
    float switchTimer;
    // Start is called before the first frame update
    void Start()
    {
        switchTimer=sceneSwitchTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        switchTimer-= Time.deltaTime;
        if(switchTimer<=0)
        {
            SceneManager.LoadScene(0);
        }
        
    }
    public void PlayAgain(){

        
    }
}
