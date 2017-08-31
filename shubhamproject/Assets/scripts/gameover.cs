using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void OnGUI () {
		GUI.contentColor = Color.red;

		if (GUI.Button (new Rect (Screen.width / 2-50, Screen.height / 2+10, 80, 40), "Retry ?"))
			SceneManager.LoadScene (2);
		if(GUI.Button(new Rect(Screen.width/2-50,Screen.height/2+50,80,40),"Quit "))
			Application.Quit();

	}

}
