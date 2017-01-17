using UnityEngine;
using System.Collections;

public class OriginChangerController : MonoBehaviour {

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
				transform.Translate(13, 0, 13);
				break;
			case 1:
				transform.Translate(-6, 0, -12);
				break;
			case 2:
				transform.Translate((float)-7.5, 0, (float)6.5);
				break;
			case 3:
				transform.Translate(14, 0, (float)-10.5);
				break;
			case 4:
				transform.Translate((float)-13.5, 0, 3);
				break;
			}
			time = 0;
			position = (position + 1) % 5;
		}
	}
}
