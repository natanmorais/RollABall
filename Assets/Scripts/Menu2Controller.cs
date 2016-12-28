using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu2Controller : MonoBehaviour {

	void FixedUpdate () {
		Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
		RaycastHit hit = new RaycastHit ();

		if(Physics.Raycast(ray,out hit,100)){
			if (hit.collider.gameObject == this.gameObject) {
				if (this.gameObject.CompareTag ("Phase001")) {
					SceneManager.LoadScene ("Level11", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase002")) {
					SceneManager.LoadScene ("Level12", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase003")) {
					SceneManager.LoadScene ("Level13", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase004")) {
					SceneManager.LoadScene ("Level14", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase005")) {
					SceneManager.LoadScene ("Level15", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase006")) {
					SceneManager.LoadScene ("Level16", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase007")) {
					SceneManager.LoadScene ("Level17", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase008")) {
					SceneManager.LoadScene ("Level18", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase009")) {
					SceneManager.LoadScene ("Level19", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase010")) {
					SceneManager.LoadScene ("Level20", LoadSceneMode.Single);
				}
			}
		}
	}
}
