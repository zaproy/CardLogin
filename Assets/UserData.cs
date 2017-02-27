using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserData : MonoBehaviour {

	public Text cardNum;
	public Text userName;
	public Text point;
	public Text[] menu;

	public int sceneNum;
	// Use this for initialization
	void Start () {
		if (sceneNum == 1) {
			cardNum.text = "180012568700";
			userName.text = "Saranya Khanjanalekha";
		} else if (sceneNum == 2) {

			point.text = "150";
			menu [0].text = "Capucino";
			menu [1].text = "Mocha";
			menu [2].text = "Chocolate";
			menu [3].text = "Matcha";
			menu [4].text = "10$";
			menu [5].text = "11$";
			menu [6].text = "15$";
			menu [7].text = "9$";
			menu [8].text = "Total : 45$";
			menu[9].text = "Budget : 200$";
		}
	}
	
	public void LogOut(){
		SceneManager.LoadScene (0);
	}

	public void ToHomeScene(){
		SceneManager.LoadScene (1);
	}

	public void ToBudgetScene(){
		SceneManager.LoadScene (2);
	}
}
