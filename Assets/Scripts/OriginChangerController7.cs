using UnityEngine;
using System.Collections;

public class OriginChangerController7 : MonoBehaviour {

	private float time = 0;
	private int position = 1;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if (time > 6) {
			switch (position) {
			case 0:
				transform.Translate (6, 0, -9); //0 e 4
				break;
			case 1:
				transform.Translate (6, 0, 7); //6 e 11
				break;
			case 2:
				transform.Translate (-7, 0, -2); //-1 e 9
				break;
			case 3:
				transform.Translate (8, 0, -5); //7 e 4
				break;
			case 4:
				transform.Translate (-13, 0, 9); //-6 e 13
				break;
			}
			time = 0;
			position = (position + 1) % 5;
		}
	}
}
