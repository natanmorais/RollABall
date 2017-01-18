using UnityEngine;
using System.Collections;

public class OriginChangerController3 : MonoBehaviour {

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
				transform.Translate (8, 0, 3); //5.5 e 1.5
				break;
			case 1:
				transform.Translate (-12, 0, (float)3.75); //-6.5 e 5.25
				break;
			case 2:
				transform.Translate ((float)-1.5, 0, (float)-10.25); //-8 e -5
				break;
			case 3:
				transform.Translate (11, 0, 12); //3 e 7
				break;
			case 4:
				transform.Translate ((float)-5.5, 0, (float)-8.5); //-2.5 e -1.5
				break;
			}
			time = 0;
			position = (position + 1) % 5;
		}
	}
}
