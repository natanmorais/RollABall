using UnityEngine;
using System.Collections;

public class OriginChangerController2 : MonoBehaviour {

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
				transform.Translate (14, 0, (float)5.5); //8 e 12
				break;
			case 1:
				transform.Translate ((float)-11.5, 0, 1); //-3.5 e 13
				break;
			case 2:
				transform.Translate (2, 0, (float)-14.75); //-1.5 e -1.75
				break;
			case 3:
				transform.Translate (10, 0, (float)10.25); //8.5 e 8.5
				break;
			case 4:
				transform.Translate ((float)-14.5, 0, -2); //-6 e 6.5
				break;
			}
			time = 0;
			position = (position + 1) % 5;
		}
	}
	}
