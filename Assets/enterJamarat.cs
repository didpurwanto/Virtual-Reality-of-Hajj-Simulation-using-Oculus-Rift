using UnityEngine;
using System.Collections;

public class enterJamarat : MonoBehaviour {
	

	void OnTriggerEnter(Collider col){
		Application.LoadLevel ("scene_jamarat");
	}

}
