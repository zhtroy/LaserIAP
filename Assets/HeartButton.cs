using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartButton : MonoBehaviour {

    public Animator ani;

    public void Shake()
    {

        ani.SetTrigger("shake");
    }
}
