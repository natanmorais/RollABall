using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu3Controller : MonoBehaviour {

	void FixedUpdate () {
		Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
		RaycastHit hit = new RaycastHit ();

		if(Physics.Raycast(ray,out hit,100)){
			if (hit.collider.gameObject == this.gameObject) {
				if (this.gameObject.CompareTag ("Phase001")) {
					SceneManager.LoadScene ("Level21", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase002")) {
					SceneManager.LoadScene ("Level22", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase003")) {
					SceneManager.LoadScene ("Level23", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase004")) {
					SceneManager.LoadScene ("Level24", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase005")) {
					SceneManager.LoadScene ("Level25", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase006")) {
					SceneManager.LoadScene ("Level26", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase007")) {
					SceneManager.LoadScene ("Level27", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase008")) {
					SceneManager.LoadScene ("Level28", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase009")) {
					SceneManager.LoadScene ("Level29", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase010")) {
					SceneManager.LoadScene ("Level30", LoadSceneMode.Single);
				}
			}
		}
	}
}
