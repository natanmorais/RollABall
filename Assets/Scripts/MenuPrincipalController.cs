using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuPrincipalController : MonoBehaviour {

	void FixedUpdate () {
		Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
		RaycastHit hit = new RaycastHit ();

		if(Physics.Raycast(ray,out hit,100)){
			if (hit.collider.gameObject == this.gameObject) {
				if (this.gameObject.CompareTag ("Menu01")) {
					SceneManager.LoadScene ("MenuBase", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Menu02")) {
					SceneManager.LoadScene ("Menu2", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Menu03")) {
					SceneManager.LoadScene ("Menu3", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Menu04")) {
					SceneManager.LoadScene ("Menu4", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Menu05")) {
					SceneManager.LoadScene ("Menu5", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Menu06")) {
					SceneManager.LoadScene ("Menu6", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Menu07")) {
					SceneManager.LoadScene ("Menu7", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Menu08")) {
					SceneManager.LoadScene ("Menu8", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Menu09")) {
					SceneManager.LoadScene ("Menu9", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Menu10")) {
					SceneManager.LoadScene ("Menu10", LoadSceneMode.Single);
				}
			}
		}
	}
}