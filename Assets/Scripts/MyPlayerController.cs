using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyPlayerController : MonoBehaviour
{
    float maxDistance = 25.0f;
    public GameObject bullet;
    public float bulletSpeed = 40.0f;
    public float minFOV = 15.0f;
    public float maxFOV = 60.0f;
    public float sensitivity = 90.0f;
    public int lives = 10;
    public int maxLives = 10;
    public int EthansHit=0;
    Text tex;

    // Start is called before the first frame update
    void Start()
    {
        tex = FindObjectOfType<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tex.text="Lives: " +lives.ToString();
        Debug.DrawRay(Camera.main.transform.position,
            Camera.main.transform.forward * maxDistance,
            Color.green);

       /*
        if (Physics.Raycast(Camera.main.transform.position,
            Camera.main.transform.forward * maxDistance,
            out hit))
        {
            Debug.Log("Found " + hit.transform.gameObject.tag + " at " + hit.distance + " meters");

        }
       */

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject go = Instantiate(bullet, Camera.main.transform.position,
                Camera.main.transform.rotation);
            Rigidbody rb = go.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * bulletSpeed;

        }

        float currentFOV = Camera.main.fieldOfView;
        currentFOV += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        currentFOV = Mathf.Clamp(currentFOV, minFOV, maxFOV);
        Camera.main.fieldOfView = currentFOV;

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ethan")
        {
            Destroy(other.gameObject);
            lives--;
            if (lives <= 0)
            {
                SceneManager.LoadScene(1);
                Debug.Log("Game Over");
            }
        }
    }

    public void MaxLives()
    {
        lives = maxLives;
        Debug.Log(lives);
    }
    
}
