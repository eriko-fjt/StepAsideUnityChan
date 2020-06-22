using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyerController : MonoBehaviour {

	
	GameObject mainCamera;





	// Use this for initialization
	void Start () {

		this.mainCamera = Camera.main.gameObject;

		
		
	}
	
	// Update is called once per frame
	void Update () {

		
		this.transform.position = new Vector3(0, this.mainCamera.transform.position.y -1, this.mainCamera.transform.position.z -0.01f);
		
	}


    void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "CoinTag" || other.gameObject.tag == "TrafficConeTag" ||  other.gameObject.tag == "CarTag")
        {
			Destroy(other.gameObject);
		}
		
    }
}
