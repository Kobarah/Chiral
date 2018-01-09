using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{

    public string text; //stringa di testo
    private bool display = false; //booleano per verificare se il testo è visualizzato
    public AudioClip picked;
    public AudioSource AudioSource;
    private bool pressedKey;

    // Use this for initialization
    void Start ()

    {

        AudioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update ()

    {

        if (Input.GetKeyDown(KeyCode.Mouse0) && display == true)

        {

            pressedKey = true;
            AudioSource.clip = picked;
            AudioSource.Play();
            
        }

    }

    private void OnTriggerEnter(Collider collisione)

    {

        if (collisione.transform.name == "vThirdPersonController")  //Se l'oggetto chiamato vThirdPersonController entra in collisione 
        {

            display = true;

        }

    }

    private void OnTriggerExit(Collider nonCollisione)

    {

        if (nonCollisione.transform.name == "vThirdPersonController") //Se l'oggetto chiamato vThirdPersonController non è in collisione

        {

            display = false;
            pressedKey = false;

        }


    }

    private void OnGUI()

    {
        if (display == true && pressedKey == true) //Se il booleano display è true

        {

            GUI.Label(new Rect(350, 400, Screen.width, Screen.height), text); //Stampa il messaggio che dico io 


        }


    }

}
