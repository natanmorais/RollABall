using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

	public float timeLeft;
	private Text timer;
	public GameObject player;

	// Use this for initialization
	void Start () {
		timer = GetComponent<Text> ();
		setaTempo (timeLeft.ToString("0"));
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;

		if (timeLeft < 0) {
			setaTempo ("END");
			player.SetActive (false);
		} else {
			setaTempo (timeLeft.ToString("0"));
		}
	}

	void setaTempo(string tempo) {
		timer.text = tempo;
	}
}
