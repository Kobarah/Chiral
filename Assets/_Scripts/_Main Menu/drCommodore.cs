using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class drCommodore : MonoBehaviour
{

    // Use this for initialization
    private float Timer = 4f;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()

    {

        Timer -= Time.deltaTime;
        if (Timer <= 0f)

        {

            SceneManager.LoadScene("mainMenu");

        }
        if (Input.GetKeyDown(KeyCode.Mouse0))

        {

            SceneManager.LoadScene("mainMenu");

        }
    }



}