using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball6 : MonoBehaviour
{
    private Camera cam;
    private Rigidbody2D rigidBody2D;
	private bool isMoving = false;
	private Vector2 mousePos;
	public float velocity = 5f;
	
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetMouseButtonDown(0)) 
        {
			mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
			Debug.Log(mousePos);
			isMoving = true;
        }
        
        if (isMoving == true) 
        {
			transform.position = Vector2.MoveTowards(transform.position, mousePos, velocity * Time.deltaTime);
		}
		
		Vector2 ballPos = transform.position;
		if(ballPos == mousePos) isMoving = false;
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        isMoving = false;
    }
}
