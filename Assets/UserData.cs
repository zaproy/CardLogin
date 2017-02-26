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

	// Use this for initialization
	void Start () {
		cardNum.text = "180012568700";
		userName.text = "Saranya Khanjanalekha";
		point.text = "150";
		menu[0].text = "Capucino";
		menu[1].text = "Mocha";
		menu[2].text = "Chocolate";
		menu[3].text = "Matcha";
	}
	
	public void LogOut(){
		SceneManager.LoadScene (0);
	}
}
