using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInventory : MonoBehaviour
{
    public Text nom;
    public Text desc;
    
    public void OnClick_CarteIzly()
    {
        nom.text = "Carte Izly";
        desc.text = "Carte Izly";
    }

    public void OnClick_CarteEtu()
    {
        nom.text = "Carte Étudiante";
        desc.text = "Carte Étudiante";
    }

    public void OnClick_Code()
    {
        nom.text = "Code Secret";
        desc.text = "Code Secret";
    }

    public void OnClick_Corde()
    {
        nom.text = "Corde";
        desc.text = "Corde";
    }


    public void OnClick_Tuba()
    {
        nom.text = "Tuba";
        desc.text = "Tuba";
    }

    public void OnClick_Clé()
    {
        nom.text = "Clé";
        desc.text = "Clé";
    }

}
