using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour {

	void Start(){
		GetComponent<Toggle> ().isOn = SoundManager.instance.MusicSource.mute;
	}
	public void ToggleSound(){
		
		SoundManager.instance.ToggleSound (!GetComponent<Toggle> ().isOn);
	}
}
