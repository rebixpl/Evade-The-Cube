using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Stats m_stats;

    public Transform leftWall;
    public Transform rightWall;

    public HudManager hudManager;

    private void Awake()
    {
        m_stats = GetComponent<Stats>();
        hudManager.UpdateHealthText(m_stats.Health);
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
        if (m_stats.Health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float horizontalPosition = transform.position.x + horizontalInput * speed * Time.deltaTime;

        float playerSize = transform.localScale.x / 2;

        if (horizontalPosition - playerSize <= leftWall.position.x + leftWall.localScale.x / 2)
        {
            return;
        }

        if (horizontalPosition + playerSize >= rightWall.position.x - rightWall.localScale.x / 2)
        {
            return;
        }

        //Debug.Log($"H -> {horizontalInput}");
        //Debug.Log($"V /\\ {verticalInput}");

        transform.position = new Vector3(
            horizontalPosition,
            1,
            transform.position.z);


    }

    public void ReceiveDamage()
    {
        m_stats.UpdateHealth(10.0f);
        hudManager.UpdateHealthText(m_stats.Health);
        Debug.Log("Player damaged");
    }
}
