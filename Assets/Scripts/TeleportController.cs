using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    public Transform[] locations;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        int index = Random.Range(0, locations.Length);
        if (other.gameObject.tag == "Player") {
            other.gameObject.transform.position = locations[index].position;
        }

    }
}
