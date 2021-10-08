using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSquare8 : MonoBehaviour
{
    public GameObject prefab;
    
	public static GameObject staticPrefab;
    // Start is called before the first frame update
    void Start()
    {
		staticPrefab = prefab;
		
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
    
    public static void spawnSquare(Vector2 ballPos)
    {
		float[] horizontalPos = new float[2];
		horizontalPos[0] = Random.Range(-8.5f, -ballPos.x);
		horizontalPos[1] = Random.Range(ballPos.x, 8.5f);
			
		float[] verticalPos = new float[2];
		verticalPos[0] = Random.Range(-4.5f, -ballPos.y);
		verticalPos[1] = Random.Range(ballPos.y, 4.5f);
			
		Vector2 position = new Vector2(
			horizontalPos[Random.Range(0, 2)], 
			verticalPos[Random.Range(0, 2)]
		);
		Instantiate(staticPrefab, position, Quaternion.identity);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
