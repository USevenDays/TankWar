using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
//[ExecuteInEditMode]
public class TestScp : MonoBehaviour {

    Action ad;
    // Use this for initialization
    void Start () {
        print("back");
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	public void Onclick() {
        SceneManager.LoadScene(1);
        print("jumpManager");
    }
    public void Onclick2()
    {
        SceneManager.LoadScene(0);
        print("jump");
    }
}
