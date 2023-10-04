using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public bool isDead = false; 
    private Rigidbody2D rb;
    public float Jump;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump")) {
            rb.AddForce(new Vector2(rb.velocity.x, Jump));
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        isDead = true;
        gameManager.GameOver();
       
    }
}
