using UnityEngine;
using System.Collections;

public class moveMonster : MonoBehaviour {

	public float speed;
	private bool direction;
	public float timeDirection;
	
	private float timeOnDirection = 0;
	
	void Update () {
		if(direction)
		{
			transform.Translate(Vector2.left * speed * Time.deltaTime);
		} else {
			transform.Translate(Vector2.right * speed * Time.deltaTime);
		}
		
		timeOnDirection += Time.deltaTime;
		
		if(timeOnDirection >= timeDirection)
		{
			timeOnDirection = 0;
			direction = !direction;
		}
	}

}
