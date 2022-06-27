using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEthans : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    MyPlayerController pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = FindObjectOfType<MyPlayerController>();
        StartCoroutine(EnemyDrop());
    }
    

    IEnumerator EnemyDrop(){
        while(enemyCount<90)
        {
            xPos = Random.Range(330, 360);
            zPos = Random.Range(220, 255);
            Instantiate(theEnemy, new Vector3(xPos, 100, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.2f);
            enemyCount++;
        }
    }
}
