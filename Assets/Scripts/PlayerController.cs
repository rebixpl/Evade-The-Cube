using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    private Stats m_stats;

    private void Awake()
    {
        m_stats = GetComponent<Stats>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //GameObject enemyGameObj = GameObject.Find("Enemy");
        //EnemyController ec = enemyGameObj.GetComponent<EnemyController>();

        //Debug.Log($"Enemy Health: {ec.stats.Health}");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Debug.Log($"H -> {horizontalInput}");
        //Debug.Log($"V /\\ {verticalInput}");

        transform.position = new Vector3(
            transform.position.x + horizontalInput * speed * Time.deltaTime, 
            1, 
            transform.position.z + verticalInput * speed * Time.deltaTime);


    }
}
