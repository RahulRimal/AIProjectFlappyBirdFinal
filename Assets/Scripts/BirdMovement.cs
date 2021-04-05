using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    public GameManager gameManager;
    private Rigidbody2D rb;

    public float jumpForce = 1f;


    public float waitToRotate = 0f;
    public float waitingToRotate = 0f;
    public float turningRate = 0f;
    private Quaternion upAngle = Quaternion.Euler(0, 0, 40f);
    private Quaternion downAngle = Quaternion.Euler(0, 0, -45f);


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
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, upAngle, turningRate*Time.deltaTime*5);
            waitingToRotate = 0f;

        }

        if(transform.rotation.z > 0 && waitingToRotate > 0.3f)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), turningRate*Time.deltaTime);
        }

        if(waitingToRotate > waitToRotate)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, downAngle, turningRate*Time.deltaTime);
        }
        else
        {
            waitingToRotate += Time.deltaTime;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.gameOver();
    }
}
