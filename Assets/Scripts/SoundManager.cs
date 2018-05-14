using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	static public SoundManager instance = null;
	public AudioSource MusicSource;
	public AudioSource SfxSource;

	public AudioClip PlayerMove;
	public AudioClip LaserShoot;
	public AudioClip PlayerDie;



	void Awake(){
		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
		}
			

		DontDestroyOnLoad (gameObject);
	}

	void Start(){
		StartCoroutine (DelayMusic ());
	}

	IEnumerator DelayMusic(){
		yield return new WaitForSeconds (0.5f);
		MusicSource.Play ();
	}
	public void PlaySfx(AudioClip clip){
		SfxSource.PlayOneShot (clip);
	}

	public void ToggleSound(bool on){
		if (on) {
			MusicSource.mute = false;
			SfxSource.mute = false;
		} else {
			MusicSource.mute = true;
			SfxSource.mute = true;
		}
	}
	public void ResetMusic(){
		MusicSource.Stop ();
		MusicSource.Play ();
	}
}
