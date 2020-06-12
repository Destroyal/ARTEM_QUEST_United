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
        desc.text = "La condition sine qua non pour avoir une chance de déjeuner au CROUS.";
    }

    public void OnClick_CarteEtu()
    {
        SurvivorScript surv_script = GameObject.Find("Survivor").GetComponent<SurvivorScript>();
        nom.text = "Carte Étudiante";
        desc.text = "Le nom de l'étudiant figurant sur la carte est " + surv_script.nom + ". Il s'agit d'un étudiant " + surv_script.formation;
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
        nom.text = "Peinture mystérieuse";
        desc.text = "Il est écrit derrière la peinture que celle-ci a été réalisée par Kristoffer Zetterstand en 2010.";
    }

    public void OnClick_Corde()
    {
        nom.text = "Corde";
        desc.text = "Un morceau de corde long et résistant pouvant être utilisé pour accéder à des zones impraticables.";
    }


    public void OnClick_Tuba()
    {
        nom.text = "Masque et Tuba";
        desc.text = "Un vieil équippement qui semble dater de l'avant guerre. Cependant, celui-ci semble toujours en état.";
    }


    public void OnClick_Jouet()
    {
        nom.text = "Jouet";
        desc.text = "Une petite voiture qui a dû moisir pendant un certain temps dans le lac.";
    }

    public void OnClick_Clé()
    {
        nom.text = "Clé claquée";
        desc.text = "Une très grosse clé que quelqu'un a dû, un jour, égarer à 200m de profondeur.";
    }

}
