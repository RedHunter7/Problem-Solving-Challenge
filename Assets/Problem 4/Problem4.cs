using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem4 : MonoBehaviour
{
	private Rigidbody2D rigidBody2D;
	public float velocity = 5f;
	
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void FixedUpdate()
    {	
		Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		rigidBody2D.MovePosition(rigidBody2D.position + (input * velocity * Time.fixedDeltaTime));
	}
}
