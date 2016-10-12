using UnityEngine;
using System.Collections;

public class informasi_ar : VRGUI {

	public bool flag = false;

	public override void OnVRGUI ()
	{
		if (flag == true)
		{
			if(gameObject.name == "inf_arafah")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Jabal Rahmah");
				GUILayout.Button("Tugu dimana tempat bertemunya \n Nabi Adam dan Siti Hawa");
				GUILayout.EndArea();
			}
			

		}
		else 
		{
			flag = false;
		}
	}

	public void onTriggerEnter(Collider coll)
	{
		if (coll.gameObject.name == "inf_arafah")
		{
			flag = true;
			gameObject.name = "inf_arafah";			
		}

	}
	public void OnTriggerExit(Collider coll)
	{
		flag = false;
	}
}
