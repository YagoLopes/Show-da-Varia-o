using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandosBasicos : MonoBehaviour {
public void carregaCena(string nomeCena)
    {
        Application.LoadLevel(nomeCena);

      

        

    }
    public void resetarPontuacoes()
    {
        PlayerPrefs.DeleteAll();

    }

}