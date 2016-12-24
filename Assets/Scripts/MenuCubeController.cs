using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuCubeController : MonoBehaviour {

	void FixedUpdate () {
		Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
		RaycastHit hit = new RaycastHit ();

		if(Physics.Raycast(ray,out hit,100)){
			if (hit.collider.gameObject == this.gameObject) {
				if (this.gameObject.CompareTag ("Phase001")) {
					SceneManager.LoadScene ("MiniGame", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase002")) {
					SceneManager.LoadScene ("Level2", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase003")) {
					SceneManager.LoadScene ("Level3", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase004")) {
					SceneManager.LoadScene ("Level4", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase005")) {
					SceneManager.LoadScene ("Level5", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase006")) {
					SceneManager.LoadScene ("Level6", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase007")) {
					SceneManager.LoadScene ("Level7", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase008")) {
					SceneManager.LoadScene ("Level8", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase009")) {
					SceneManager.LoadScene ("Level9", LoadSceneMode.Single);
				}
				if (this.gameObject.CompareTag ("Phase010")) {
					SceneManager.LoadScene ("Level10", LoadSceneMode.Single);
				}
			}
		}
	}
}
