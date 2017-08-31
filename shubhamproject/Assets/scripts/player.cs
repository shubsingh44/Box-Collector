using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip Jump;
	public AudioClip Coin;
	public AudioClip Win;
	public AudioClip gamesound;
	public float speed;
	public float jump;
	float moveVelocity;
	bool grounded ; 
	public int coins;
	public float timeRemaining=60;
	public TextMesh score;
	public TextMesh time;
	void Update () {
		timeRemaining -= Time.deltaTime;
		time.text = (int)timeRemaining+"";
		if (timeRemaining <= 0) {
			Application.LoadLevel (2);

		
		
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.localScale = new Vector2 (14, 14); 
			transform.Translate (Vector2.right * 30f * Time.deltaTime);	
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.localScale = new Vector2 (-14, 14); 
			transform.Translate (Vector2.right * -30f * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.W)) {  
			if (grounded) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jump); 
				audioSource.clip = Jump;
				audioSource.Play ();
				}
      }
	}
	void OnTriggerExit2D(){
		grounded = false;
	}
	void OnCollisionStay2D(Collision2D coll) {
		if (coll.gameObject.tag == "level2") {
			//coll.gameObject.SendMessage("Enter in new level");
				Application.LoadLevel(1);
		
		}
	}

	void  OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag=="Coin")
		{
			coins++;
			score.text=coins + "";
			Destroy(other.gameObject);
			audioSource.clip=Coin;
			audioSource.Play();
		}
		else if(other.tag== "spikes" )
		{
			Debug.Log("Dead !");
			Application.LoadLevel(2);
		}

		else if(other.tag== "gameover" )
		{
			
			Application.LoadLevel(2);
		}

		else
		{
		if (grounded == true)
			grounded = false;
		else
			grounded = true;
		}
	}
}
	
	

 

