using UnityEngine;
using System.Collections;

public class OriginChangerController6 : MonoBehaviour {

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
				transform.Translate (3, 0, 0); //-2 e 11
				break;
			case 1:
				transform.Translate (-3, 0, (float)-10.5); //-5 e 0.5
				break;
			case 2:
				transform.Translate (11, 0, (float)8.5); //6 e 9
				break;
			case 3:
				transform.Translate (2, 0, -14); //8 e -5
				break;
			case 4:
				transform.Translate (-13, 0, 16); //-5 e 11
				break;
			}
			time = 0;
			position = (position + 1) % 5;
		}
	}
}
