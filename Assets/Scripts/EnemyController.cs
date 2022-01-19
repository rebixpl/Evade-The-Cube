using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Stats m_stats;
    private void Awake()
    {
        m_stats = GetComponent<Stats>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //GameObject enemyGameObj = GameObject.Find("Player");
        //PlayerController pc = enemyGameObj.GetComponent<PlayerController>();

        //Debug.Log($"Player Health: {pc.stats.Health}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
