using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Enemy;
    public float Time;
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Repeat()
    {
        StartCoroutine(SpawnEnemy());
        
    }
    

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(Time);
        Instantiate(Enemy, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
