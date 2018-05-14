using UnityEngine;
using System.Collections;

public class GameInfoManager : MonoBehaviour {
	public static GameInfoManager instance = null;

	public int bestScore {
		get;
		set;
	}
	public int needTutorial {
		get;
		set;
	}
	public int adsCounter {
		get;
		set;
	}

	void Awake(){
		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);

		LoadGameInfo ();

		Input.multiTouchEnabled = false;
	
	}

	void OnApplicationQuit(){
		SaveGameInfo ();
		Debug.Log ("app quit, save playerpref");
	}
		

	void OnApplicationPause(bool pauseState){
		if (pauseState) {
			SaveGameInfo ();
			Debug.Log ("app pause , save on pause");
		}
	}

	void SaveGameInfo(){
		PlayerPrefs.SetInt ("BestScore", bestScore);
	}
	void LoadGameInfo(){
		bestScore = PlayerPrefs.GetInt ("BestScore", 0);
		needTutorial = 1;
	}
		
}
