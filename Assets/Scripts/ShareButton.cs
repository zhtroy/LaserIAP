using UnityEngine;
using System.Collections;

public class ShareButton : MonoBehaviour {
	private NativeShare shareTool;


	void Start(){
		shareTool = GetComponent<NativeShare> ();
	}
	public void ShareToSNS(){
		string shareText;
		if (Application.systemLanguage == SystemLanguage.Chinese) {
			shareText = "我在#Laser Dodger#里达到了" + GameManager.instance.score + "分，你也来试试吧。";
		} else {
			shareText = "I scored " + GameManager.instance.score + " in the game #Laser Dodger#.";
		}
		string url;
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			url = "https://itunes.apple.com/us/app/laser-dodger/id1167313676?ls=1&mt=8";
		} else if (Application.platform == RuntimePlatform.Android) {
			url = "";
		} else {
			url = "";
		}
		StartCoroutine( shareTool.ShareScreenshotWithTextAndUrl (shareText, url));
			
	}
}