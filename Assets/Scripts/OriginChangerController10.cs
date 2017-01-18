using UnityEngine;
using System.Collections;

public class OriginChangerController10 : MonoBehaviour {

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
				transform.Translate (15, 0, 13); //9 e 12
				break;
			case 1:
				transform.Translate (-3, 0, -10); //6 e 2
				break;
			case 2:
				transform.Translate (-6, 0, 8); //0 e 10
				break;
			case 3:
				transform.Translate (5, 0, -14); //5 e -4
				break;
			case 4:
				transform.Translate (-11, 0, 3); //-6 e -1
				break;
			}
			time = 0;
			position = (position + 1) % 5;
		}
	}
}
