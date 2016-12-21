using UnityEngine;
using System.Collections;

public class MenuCameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int height, width, distancia;
		height = Screen.height;
		width = Screen.width;
		if (height > width) {
			distancia = height / 150;
		} else {
			distancia = width / 150;
		}
		Vector3 v3 = new Vector3 (0.0f, distancia, 0.0f);
		transform.position = v3;
	}

}
