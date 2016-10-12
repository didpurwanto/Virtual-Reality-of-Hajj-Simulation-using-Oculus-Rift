using UnityEngine;
using System.Collections;

public class enterArafah : MonoBehaviour {


	void OnTriggerEnter(Collider col){
		Application.LoadLevel ("scene_arafah");
	}
}
