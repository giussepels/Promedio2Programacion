using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MyInventarySc {

	bool Selected;
	bool click;

	void Update () {

		if (Input.GetMouseButton(0)){

			Slots[indexImagenEquip].enabled=false;
			Selected = true;
		}
			else if (Input.GetMouseButton(0)) {
				Selected =false;

			}

		
			
		

		if (Selected==true){
			Slots[indexImagenEquip].enabled=false;
		}

		else if (Selected==false){
			Slots[indexImagenEquip].enabled=true;
		}
		
	}
}
