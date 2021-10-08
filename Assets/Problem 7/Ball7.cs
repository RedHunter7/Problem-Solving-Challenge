using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball7 : MonoBehaviour
{
    private Camera cam;
    private Rigidbody2D rigidBody2D;
	private bool isMoving = false;
	private Vector2 mousePos;
	public float velocity = 5f;
	private int score = 0;
	public Text scoreText;
	
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
        if(col.gameObject.tag == "Square") 
        {
			Destroy(col.gameObject);
			score++;
			scoreText.text = score.ToString();
		}
        else isMoving = false;
    }
}
