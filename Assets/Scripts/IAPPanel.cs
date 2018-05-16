using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPPanel : MonoBehaviour {

    private Animator ani;

    private void Awake()
    {
        ani = GetComponent<Animator>();
    }
    public void Hide()
    {
		
        ani.SetTrigger("hide");
    }
    public void Show()
    {
        ani.SetTrigger("show");
    }
}
