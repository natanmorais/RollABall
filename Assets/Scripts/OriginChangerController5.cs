using UnityEngine;
using System.Collections;

public class OriginChangerController5 : MonoBehaviour {

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
				transform.Translate (-3, 0, 11); //-9 e 13
				break;
			case 1:
				transform.Translate (16, 0, (float)-5.5); //7 e 7.5
				break;
			case 2:
				transform.Translate (-16, 0, (float)-12.5); //-9 e -5
				break;
			case 3:
				transform.Translate (18, 0, (float)7.5); //9 e 2.5
				break;
			case 4:
				transform.Translate (-15, 0, (float)-0.5); //-6 e 2
				break;
			}
			time = 0;
			position = (position + 1) % 5;
		}
	}
}
