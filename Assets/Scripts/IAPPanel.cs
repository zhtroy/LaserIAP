using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPPanel : MonoBehaviour {

    public Animator ani;


    public void Hide()
    {
		
        ani.SetTrigger("hide");
    }
    public void Show()
    {
        ani.SetTrigger("show");
    }
}
