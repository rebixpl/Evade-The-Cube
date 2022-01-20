using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 6f;

    private PlayerController m_PC;
    private Stats m_stats;
    private float m_TresholdPositionZ = -20.0f;

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

        m_PC = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - speed * Time.deltaTime);

        // measure distance between the enemy and player position

        if (Vector3.Distance(m_PC.transform.position, transform.position) < 1.0f)
        {
            m_PC.ReceiveDamage();
            Destroy(gameObject);
        }
        else
        if (transform.position.z <= m_TresholdPositionZ)
        {
            Destroy(gameObject);
        }
    }
}
