using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartText : MonoBehaviour {

	public Text heartText;
	// Use this for initialization
	void Start () {
		if (GameInfoManager.instance!=null) {
			GameInfoManager.instance.onLifeChange += OnLifeChange;
		}
		OnLifeChange (GameInfoManager.instance.life);
	}

	void OnDestroy()
	{
		if (GameInfoManager.instance != null) {
			GameInfoManager.instance.onLifeChange -= OnLifeChange;
		}
	}
		

	void OnLifeChange(int value)
	{
		heartText.text = value.ToString ();
	}
	

}
