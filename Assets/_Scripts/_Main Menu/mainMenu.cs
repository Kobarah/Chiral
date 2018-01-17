using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {
    //public GUIStyle style; //dichiaro lo stile della GUI 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnGUI()

    {

        GUILayout.BeginArea(new Rect(Screen.width/2-250, Screen.height / 2 - 250, 500, 500)); //mi creo un layout, gli do forma rettangolare e gli do larghezza, altezza e dimensioni
       if (GUILayout.Button("Testa il Gioco"))
            {

                SceneManager.LoadScene("vThirdPersonController-Demo");

            } //mi creo un bottone //, style dopo le virgolette del testo richiama la personalizzazione nella hierarchy
        GUILayout.Button("Carica (non funziona)");
        GUILayout.Button("Continua (non funziona)");
        GUILayout.Button("Opzioni (non funziona)");
        if (GUILayout.Button("Esci"))
        {
            Application.Quit();
        }
        GUILayout.EndArea();

    }
}
