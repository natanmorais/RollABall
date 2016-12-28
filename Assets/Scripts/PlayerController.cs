using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float speed;
	public int group;
	private int placar = 0;
	public GameObject origem;
	public Material oRed, oGreen;

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
		if (other.gameObject.CompareTag ("Pick Up") || other.gameObject.CompareTag ("Image"))
		{
			other.gameObject.SetActive (false);
			//Descrever o método de ganho de moedas
		}
		if (other.gameObject.CompareTag ("Origin")) {
			if(group==1)SceneManager.LoadScene("MenuBase",LoadSceneMode.Single);
			if(group==2)SceneManager.LoadScene("Menu2",LoadSceneMode.Single);
		}
	}
}
