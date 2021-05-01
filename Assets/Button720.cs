using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button720 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Switch to 1280 x 720
        // 设置为窗口化1280*720
        Screen.SetResolution(1280, 720, false);
    }

    // Update is called once per frame
    void Update () {

    }
}
