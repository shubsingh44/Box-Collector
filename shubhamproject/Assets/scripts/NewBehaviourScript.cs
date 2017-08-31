/*using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	int timeRemaining=120;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
      
		timeRemaining -= Time.deltaTime;
	}
	void OnGUI(){
		if (timeRemaining > 0) {
			GUI.Label (new Rect (100, 100, 200, 100), "\tTime Remaining : \n\t\t" + (int)timeRemaining);
		}
			else{
			GUI.Label (new Rect (100, 100, 100, 100), "Time's up");
		
		}	
	}
}*/
