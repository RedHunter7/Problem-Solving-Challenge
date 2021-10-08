using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSquare6 : MonoBehaviour
{
	public GameObject prefab;
	
    // Start is called before the first frame update
    void Start()
    {
		
        for (int i = 0; i < Random.Range(10, 16); i++)
        {
			float[] horizontalPos = new float[2];
			horizontalPos[0] = Random.Range(-8.5f, -0.5f);
			horizontalPos[1] = Random.Range(0.5f, 8.5f);
			
			float[] verticalPos = new float[2];
			verticalPos[0] = Random.Range(-4.5f, -0.3f);
			verticalPos[1] = Random.Range(0.3f, 4.5f);
			
			Vector2 position = new Vector2(
				horizontalPos[Random.Range(0, 2)], 
				verticalPos[Random.Range(0, 2)]
			);
			
			Instantiate(prefab, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
