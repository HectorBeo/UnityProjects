using UnityEngine;
using System.Collections;

public class monster01 : MonoBehaviour {

	public float speed;
	public bool direction;
	public float timeDirection;
	private Transform colider;
	
	private float timeOnDirection;
	private Animator anima;

	// Use this for initialization
	void Start () {
		anima = gameObject.transform.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(direction)
		{
			transform.eulerAngles = new Vector2(0, 0);
		} else {
			transform.eulerAngles = new Vector2(0, 180);
		}
		
		transform.Translate(Vector2.right * speed * Time.deltaTime);

		timeOnDirection += Time.deltaTime;
		if(timeOnDirection >= timeDirection)
		{
			timeOnDirection = 0;
			direction = !direction;
		}
	}

/* Função de causa de dano em andamento
	//Função para causar dano no player
	void OnCollisionEnter2D(Collision2D colisor){
		//Caso entre em colisão com o Player
		if(colisor.gameObject.tag == "Player")
		{
			//Animação de ataque
			anima.SetTrigger("Attack");
			var player = colisor.gameObject.transform.GetComponent<Player>();
			colider = gameObject.transform.GetComponent<Transform>();
			
			player.lostLife(10);
			colisor.gameObject.transform.Translate(Vector2.Reflect(colider.position*(0.5f), Vector3.right));
			
		}
	}
*/
}
