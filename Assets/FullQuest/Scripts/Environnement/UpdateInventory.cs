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
        SurvivorScript surv_script = GameObject.Find("Survivor").GetComponent<SurvivorScript>();
        nom.text = "Carte Étudiante";
        desc.text = "Nom : " + surv_script.nom + " ; Étudiant " + surv_script.formation;
        if (surv_script.formation == "Ingénieur")
        {
            desc.text = desc.text + " à l'École des Mines.";
        }
        if (surv_script.formation == "Manager")
        {
            desc.text = desc.text + " à l'ICN.";
        }

        if (surv_script.formation == "Artiste")
        {
            desc.text = desc.text + " à l'ENSAD.";
        }
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
