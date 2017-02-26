using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogIn : MonoBehaviour {

	public InputField user, pass;
	public string username,password;
	public GameObject wrongTx;

	void Start () {
		
		wrongTx.SetActive (false);
	}

	public void LoginSys(){
		if (user.text == username && pass.text == password) {
			SceneManager.LoadScene (1);
		} else {
			wrongTx.SetActive (true);
		}
	}
}
