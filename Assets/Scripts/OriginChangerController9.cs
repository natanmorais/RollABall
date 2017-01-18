using UnityEngine;
using System.Collections;

public class OriginChangerController9 : MonoBehaviour {

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
				transform.Translate (5, 0, (float)2.5); //8 e 9
				break;
			case 1:
				transform.Translate (-17, 0, -7); //-9 e 2
				break;
			case 2:
				transform.Translate (9, 0, (float)8.5); //0 e 10.5
				break;
			case 3:
				transform.Translate (-4, 0, -15); //-4 e -4.5
				break;
			case 4:
				transform.Translate (7, 0, 11); //3 e 6.5
				break;
			}
			time = 0;
			position = (position + 1) % 5;
		}
	}
}
