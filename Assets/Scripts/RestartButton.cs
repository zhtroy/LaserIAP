﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour {
    public TransitionOut transToSelf;
    public IAPPanel panelIAP;
    public HeartButton heart;
	// Use this for initialization
	void Start () {
		
	}
	
    public void OnClick()
    {
        if (GameInfoManager.instance.life>0)
        {
            GameInfoManager.instance.life--;
            transToSelf.gameObject.SetActive(true);
        }
        else
        {
            heart.Shake();
        }
    }
}
