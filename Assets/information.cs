using UnityEngine;
using System.Collections;

public class information : VRGUI {
	
	public bool flag = false;
	
	
	public override void OnVRGUI()
	{
		if (flag == true)
		{
			if(gameObject.name == "inf_maqam")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Maqam Ibrahim");
				GUILayout.Button("Prasati di depan Ka'bah yang berbentuk kotak dengan pahatan\n yang mengikuti jejak kaki Nabi Ibrahim saat membangun baitullah");
				GUILayout.EndArea();
			}

			else if(gameObject.name == "inf_kabah")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
				GUILayout.Button("Kabah");
				GUILayout.Button("Bangunan suci yang berada di Makkah dan menjadi \n arah kiblat sholat umat muslim sedunia" );
				GUILayout.EndArea();
			}

			else if(gameObject.name == "inf_hijr_ismail")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));			
				GUILayout.Button("Hijr Ismail");
				GUILayout.Button("Tembok berbentuk setengah lingkaran yang menjadi kuburan Nabi Ismail dengan ibunya" );
				GUILayout.EndArea();
			}

			else if(gameObject.name == "inf_marwah")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));			
				GUILayout.Button("Marwah");
				GUILayout.Button("Dahulu Siti Hajar berlari-lari kecil dari \n Bukit Shofa ke Bukit Marwah untuk mencari air untuk Ismal" );
				GUILayout.EndArea();
			}

			else if(gameObject.name == "inf_shofa")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));			
				GUILayout.Button("Shofa");
				GUILayout.Button("Dahulu Siti Hajar berlari-lari kecil dari \n Bukit Shofa ke Bukit Marwah untuk mencari air untuk Ismal" );
				GUILayout.EndArea();
			}
			
			else if(gameObject.name == "inf_menara3")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));			
				GUILayout.Button("Marwah");
				GUILayout.Button("Menara dengan tinggi 89 meter yang berada di sisi-sisi Masjid" );
				GUILayout.EndArea();
			}

			else if(gameObject.name == "inf_menara2")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));			
				GUILayout.Button("Marwah");
				GUILayout.Button("Menara dengan tinggi 89 meter yang berada di sisi-sisi Masjid" );
				GUILayout.EndArea();
			}

			else if(gameObject.name == "inf_menara")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));			
				GUILayout.Button("Marwah");
				GUILayout.Button("Menara dengan tinggi 89 meter yang berada di sisi-sisi Masjid" );
				GUILayout.EndArea();
			}

			else if(gameObject.name == "inf_menara4")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));			
				GUILayout.Button("Marwah");
				GUILayout.Button("Menara dengan tinggi 89 meter yang berada di sisi-sisi Masjid" );
				GUILayout.EndArea();
			}

			else if(gameObject.name == "inf_menara5")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));			
				GUILayout.Button("Marwah");
				GUILayout.Button("Menara dengan tinggi 89 meter yang berada di sisi-sisi Masjid" );
				GUILayout.EndArea();
			}

			else if(gameObject.name == "inf_lantai2")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));			
				GUILayout.Button("Marwah");
				GUILayout.Button("Lantai 2 Masjid al Haram. Anda bisa berkeliling disini \n atau langsung naik ke lantai 3" );
				GUILayout.EndArea();
			}

			else if(gameObject.name == "inf_lantai3")
			{
				GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));			
				GUILayout.Button("Marwah");
				GUILayout.Button("Lantai 3 Masjid al Haram. Terdapat kubah-kubah \ndan menara masjid yang berjumlah 9" );
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
		if (coll.gameObject.name == "inf_maqam")
		{
			flag = true;
			gameObject.name = "inf_maqam";			
		}
		
		if (coll.gameObject.name == "inf_kabah") 
		{
			flag = true;
			gameObject.name = "inf_kabah";
		}

		if (coll.gameObject.name == "inf_marwah") 
		{
			flag = true;
			gameObject.name = "inf_marwah";
		}

		if (coll.gameObject.name == "inf_shofa") 
		{
			flag = true;
			gameObject.name = "inf_shofa";
		}

		if (coll.gameObject.name == "inf_hijr_ismail") 
		{
			flag = true;
			gameObject.name = "inf_hijr_ismail";
		}

		if (coll.gameObject.name == "inf_menara3") 
		{
			flag = true;
			gameObject.name = "inf_menara3";
		}

		if (coll.gameObject.name == "inf_menara2") 
		{
			flag = true;
			gameObject.name = "inf_menara2";
		}

		if (coll.gameObject.name == "inf_menara") 
		{
			flag = true;
			gameObject.name = "inf_menara";
		}

		if (coll.gameObject.name == "inf_menara4") 
		{
			flag = true;
			gameObject.name = "inf_menara4";
		}

		if (coll.gameObject.name == "inf_menara5") 
		{
			flag = true;
			gameObject.name = "inf_menara5";
		}

		if (coll.gameObject.name == "inf_lantai2") 
		{
			flag = true;
			gameObject.name = "inf_lantai2";
		}

		if (coll.gameObject.name == "inf_lantai3") 
		{
			flag = true;
			gameObject.name = "inf_lantai3";
		}


	}
	
	public void OnTriggerExit(Collider coll)
	{
		flag = false;
	}
}
