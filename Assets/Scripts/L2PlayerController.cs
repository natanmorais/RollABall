using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class L2PlayerController : MonoBehaviour {

	public float speed;
	public GameObject origem;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");

		float moveHorizontal = Input.GetTouch (0).deltaPosition.x;
		float moveVertical = Input.GetTouch (0).deltaPosition.y;

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Origin")) {
			SceneManager.LoadScene("MenuBase",LoadSceneMode.Single);
		}
	}
}
