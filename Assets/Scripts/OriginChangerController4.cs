using UnityEngine;
using System.Collections;

public class OriginChangerController4 : MonoBehaviour {

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
				transform.Translate (15, 0, -8); //6 e -4.5
				break;
			case 1:
				transform.Translate (-13, 0, 12); //-7 e 7.5
				break;
			case 2:
				transform.Translate ((float)-1.5, 0, (float)-10.5); //-8.5 e -3
				break;
			case 3:
				transform.Translate ((float)17.5, 0, 5); //9 e 2
				break;
			case 4:
				transform.Translate (-18, 0, (float)1.5); //-9 e 3.5
				break;
			}
			time = 0;
			position = (position + 1) % 5;
		}
	}
}
