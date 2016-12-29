using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SetaNextController : MonoBehaviour {
	public int group;

	void FixedUpdate () {
		Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
		RaycastHit hit = new RaycastHit ();

		if(Physics.Raycast(ray,out hit,100)){
			if (hit.collider.gameObject == this.gameObject) {
				if(group==1)SceneManager.LoadScene ("Menu2", LoadSceneMode.Single);
				if(group==2)SceneManager.LoadScene ("Menu3", LoadSceneMode.Single);
			}
		}
	}
}
