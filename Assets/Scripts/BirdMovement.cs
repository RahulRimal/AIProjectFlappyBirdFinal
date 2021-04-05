using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    public GameManager gameManager;

    public float jumpForce = 1f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // rb.velocity = Vector2.up * jumpForce*Time.deltaTime;
            rb.velocity = Vector2.up * jumpForce;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.gameOver();
    }
}
