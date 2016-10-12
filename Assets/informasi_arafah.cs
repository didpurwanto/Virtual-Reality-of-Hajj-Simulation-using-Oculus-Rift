using UnityEngine;
using System.Collections;

public class informasi_arafah : VRGUI {

	public bool flag = false;
	
	public override void OnVRGUI ()
	{
		if (flag == true)
		{
			if(gameObject.name == "informasi_000")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Jamarat");
				GUILayout.Button("Jamarat Ula adalah tempat lempar jumrah para jamaah haji");
				GUILayout.EndArea();
			}
			
			else if(gameObject.name == "informasi_001")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Pintu Gedung");
				GUILayout.Button("Anda bisa menuruni jembatan atau masuk untuk melempar jumrah");
				GUILayout.EndArea();
			}
			
			else if(gameObject.name == "informasi_002")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Tangga");
				GUILayout.Button("Tangga ini akan menghubungkan Anda dari lantai 2 dengan lantai 3");
				GUILayout.EndArea();
			}
			
			else if(gameObject.name == "informasi_003")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Jamarat");
				GUILayout.Button("Jamarat Aqobah adalah tempat lempar jumrah para jamaah haji");
				GUILayout.EndArea();
			}
			
			else if(gameObject.name == "informasi_004")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Jamarat");
				GUILayout.Button("Jamarat Wustho adalah tempat lempar jumrah para jamaah haji");
				GUILayout.EndArea();
			}
			
			else if(gameObject.name == "informasi_005")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Pintu");
				GUILayout.Button("Pintu dari arah Mina, Anda bisa menuruni jembatan untuk keluar ");
				GUILayout.EndArea();
			}
			
			else if(gameObject.name == "informasi_008")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Jamarat");
				GUILayout.Button("Jamarat Wustho adalah tempat lempar jumrah para jamaah haji");
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
		if (coll.gameObject.name == "informasi_000")
		{
			flag = true;
			gameObject.name = "informasi_000";			
		}
		
		if (coll.gameObject.name == "informasi_001")
		{
			flag = true;
			gameObject.name = "informasi_001";			
		}
		
		if (coll.gameObject.name == "informasi_002")
		{
			flag = true;
			gameObject.name = "informasi_002";			
		}
		
		if (coll.gameObject.name == "informasi_003")
		{
			flag = true;
			gameObject.name = "informasi_003";			
		}
		
		if (coll.gameObject.name == "informasi_004")
		{
			flag = true;
			gameObject.name = "informasi_004";			
		}
		
		if (coll.gameObject.name == "informasi_005")
		{
			flag = true;
			gameObject.name = "informasi_005";			
		}
		
		if (coll.gameObject.name == "informasi_008")
		{
			flag = true;
			gameObject.name = "informasi_008";			
		}
		
		
		
		
	}
	
	public void OnTriggerExit(Collider coll)
	{
		flag = false;
	}

}
