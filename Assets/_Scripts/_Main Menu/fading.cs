using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fading : MonoBehaviour {
    // Use this for initialization
    private float Timer = 5f;
    public Texture2D fadeOutTexture; //La texture che copre lo schermo
    public float fadeSpeed = 0.8f;  //Velocità transizione in uscita o in entrata
    private int drawDepth = -1000;
    private float alpha = 1.0f; //trasparenza
    private int fadeDir = -1; // fade in = -1; out = -1;

	void OnGUI ()
        
    {
        //Assegna al fade in/ out un valore alpha impostando una direzione; una velocità e un Time.deltaTime per convertire le operazioni in secondi
        alpha += fadeDir * fadeSpeed * Time.deltaTime;

        //Forza il risultato in un valore compreso tra 0 e 1 perchè GUI.Color può leggere solo questo intervallo
        alpha = Mathf.Clamp01(alpha);

        //Imposta colore della GUI (in questo caso una texture) e il valore alpha
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);

	}
	
    //Imposta fadeDir su -1 per fade in e 1 per fade out
    public float BeginFade (int direction)

    {

        fadeDir = direction;
        return (fadeSpeed);

    }

    //OnLevelWasLoaded è richiamato quando un livello è caricato, ne prende l'indice (int) come un parametro. Così si può limitare il fade nelle scene
    void sceneLoaded()

    {

        BeginFade(-1);

    }

    // Update is called once per frame
    void Update()

    {

       Timer -= Time.deltaTime;
       if (Timer <= 1f)
       

            {

               BeginFade(1);

            }
    }

    }
