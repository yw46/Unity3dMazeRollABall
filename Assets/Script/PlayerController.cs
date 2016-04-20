using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText, winText;

	private Rigidbody rb;
	private float moveHorizontal, moveVertical;
	private Vector3 movement;
	private int pickupCount, winCount;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		pickupCount = 0;
		winCount = 0;
		SetcountText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {
		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");
		movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * 10);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Pickup")) {
			other.gameObject.SetActive(false);
			pickupCount++;
			SetcountText ();
		} else if (other.gameObject.CompareTag("PickupWin")) {
			other.gameObject.SetActive(false);
			winCount++;
			winText.text = "You Win";
		}
	}

	void SetcountText () {
		countText.text = "Pickup Count :" + pickupCount.ToString ();
	}
}
