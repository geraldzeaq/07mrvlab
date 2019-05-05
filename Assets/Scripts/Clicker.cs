using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

//public class Clicker : MonoBehaviour
public class Clicker
{
    public bool clicked()
    {
        return Input.anyKeyDown;
#if (UNITY_ANDROID || UNITY_IPHONE)
		return Cardboard.SDK.CardboardTriggered;
#else
        return Input.anyKeyDown;
#endif
    }

    // Use this for initialization
    //void Start () {
    //
    //}

    // Update is called once per frame
    //void Update () {
    //
    //}
}