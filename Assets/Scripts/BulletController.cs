using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletController : MonoBehaviour
{
    public float lifeTime = 3.0f;
    float timeLeft;
    int numEthans = 55;


    // Start is called before the first frame update
    void Start()
    {
        timeLeft = lifeTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0.0f)
            Destroy(gameObject);
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Play particle effect
        MyPlayerController pc = FindObjectOfType<MyPlayerController>();
        
        if (other.gameObject.tag == "Cube")
        {
            Destroy(gameObject);
            other.gameObject.SendMessage("Damage", 1);
        }
        if (other.gameObject.tag == "Ethan")
        {
            Destroy(gameObject);
            other.gameObject.SendMessage("Damage", 1);
            pc.EthansHit++;
            Debug.Log("Ethan killed Counter: "+pc.EthansHit);
            if(pc.EthansHit >= numEthans){
                SceneManager.LoadScene(2);
            }
        }

    }
}
