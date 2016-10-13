using UnityEngine;
using System.Collections;

public class enterMasjid : MonoBehaviour {



	void OnTriggerEnter(Collider col){
		Application.LoadLevel ("scene_masjid");
	}


}
