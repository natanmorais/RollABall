using UnityEngine;
using System.Collections;

public class OriginChangerController8 : MonoBehaviour {

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
				transform.Translate (-18, 0, 0); //-9 e 13
				break;
			case 1:
				transform.Translate (7, 0, -11); //-2 e 2
				break;
			case 2:
				transform.Translate (5, 0, 4); //3 e 6
				break;
			case 3:
				transform.Translate (2, 0, -5); //5 e 1
				break;
			case 4:
				transform.Translate (4, 0, 12); //9 e 13
				break;
			}
			time = 0;
			position = (position + 1) % 5;
		}
	}
}
