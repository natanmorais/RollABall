using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float speed;
	private int placar = 0;
	private GameObject[] itens = new GameObject[12];
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
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			itens [placar] = other.gameObject;
			placar ++;
		}
		if (other.gameObject.CompareTag ("Origin") && placar == 12) {
			/*placar = 0;
			for (int i = 0; i < 12; i++) {
				itens [i].SetActive (true);
			}
			origem.GetComponent<Renderer> ().material = oRed;*/
			SceneManager.LoadScene("MenuBase",LoadSceneMode.Single);
		}
		if (placar == 12) 
		{
			origem.GetComponent<Renderer> ().material = oGreen;
		}
	}
}
