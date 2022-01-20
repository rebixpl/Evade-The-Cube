using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector2 spawnRangeX;

    //private float m_SpawnInterval = 2.0f;
    //private float m_Timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //m_Timer += Time.deltaTime;
        //if (m_Timer >= m_SpawnInterval)
        //{
        //    Instantiate(enemyPrefab);
        //    m_Timer = 0;
        //}
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(spawnRangeX.x, spawnRangeX.y),
            enemyPrefab.transform.position.y,
            enemyPrefab.transform.position.z);

        Instantiate(enemyPrefab,
            spawnPosition,
            enemyPrefab.transform.rotation);
    }
}
