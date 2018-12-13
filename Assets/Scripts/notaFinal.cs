using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notaFinal : MonoBehaviour {
    private int idTema;

    public Text txtNota;
    public Text txtInfoTema;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    private int notaF;
    private int acertos;

	// Use this for initialization
	void Start () {
        idTema = PlayerPrefs.GetInt("idTema");
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);



        
        notaF = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
        acertos = PlayerPrefs.GetInt("acertos" + idTema.ToString());


        txtNota.text = notaF.ToString();
        txtInfoTema.text = (" Voce acertou " + acertos.ToString() + " de 3 perguntas ");

        if (notaF == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);



        }
        else if(notaF >= 7 )
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaF >= 3)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);


        }


    }
    public void jogarNovamente()
    {
        Application.LoadLevel("T" + idTema.ToString());






    }




}
