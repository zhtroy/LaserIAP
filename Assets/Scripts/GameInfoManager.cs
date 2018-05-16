using UnityEngine;
using System.Collections;
using System;

public class GameInfoManager : MonoBehaviour {
	public static GameInfoManager instance = null;

	public event Action<int> onLifeChange = null;
	public int bestScore {
		get;
		set;
	}

	private int _life;
    public int life
    {
        get
		{
			return _life;
		}
        set {
			if (_life != value) {
				_life = value;
				if (onLifeChange!=null) {
					onLifeChange (_life);
				}
			}
		}
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

	public void SaveGameInfo(){
		PlayerPrefs.SetInt ("BestScore", bestScore);
        PlayerPrefs.SetInt("Life", life);
	}
	void LoadGameInfo(){
		bestScore = PlayerPrefs.GetInt ("BestScore", 0);
        life = PlayerPrefs.GetInt("Life", 2);
		needTutorial = 1;
	}
		
}
