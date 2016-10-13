using UnityEngine;
using System.Collections;

public class enterBantuan : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		Application.LoadLevel ("scene_bantuan");
	}
}
