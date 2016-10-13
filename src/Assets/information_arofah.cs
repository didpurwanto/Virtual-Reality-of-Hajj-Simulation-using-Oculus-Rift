using UnityEngine;
using System.Collections;

public class information_arofah : VRGUI {
	
	public bool flag = false;
	
	
	public override void OnVRGUI()
	{
		if (flag == true)
		{
			if(gameObject.name == "inf_arafah")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Jabal Rohmah");
				GUILayout.Button("Disinilah tempat bertemunya \n Nabi Adam dan Siti Hawa");
				GUILayout.EndArea();
			}
			

		}
		else 
		{
			flag = false;
		}
	}
	
	public void OnTriggerEnter(Collider coll)
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