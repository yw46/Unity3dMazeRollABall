using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = new Vector3 (0, 10, -10);
		transform.position = player.transform.position + offset;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
