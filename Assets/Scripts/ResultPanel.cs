using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.Advertisements;

public class ResultPanel : MonoBehaviour {
	public GameObject PauseButton;
	public Text BestScoreText;
	public int AdsInverval = 4;

	private Animator m_animator;
	void Start(){
		m_animator = GetComponent<Animator> ();

	}


	public void ShowResult(){
		PauseButton.SetActive (false);
		BestScoreText.text = "Best " + GameInfoManager.instance.bestScore.ToString ();
		BestScoreText.gameObject.SetActive (true);
		m_animator.SetTrigger ("Show");
	}

	/*public void ShowAd()
	{
		Debug.Log ("ads initialized:" + Advertisement.isInitialized);
		if (GameInfoManager.instance.adsCounter > AdsInverval) {
			if (Advertisement.IsReady ()) {
				Advertisement.Show ();
				Debug.Log ("show ads");
				GameInfoManager.instance.adsCounter = 0;
			} else {
				Debug.Log ("ads not ready");
			}
		} else {
			GameInfoManager.instance.adsCounter++;
		}
	} */
}




