using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
//[ExecuteInEditMode]
public class TestScp : MonoBehaviour {

    Action ad;
   
    void Start () {
        print("back");
        //防止销毁
        DontDestroyOnLoad(gameObject);
    }
    void Update() {

        transform.Rotate(Vector3.forward * Time.deltaTime * 20f);
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
