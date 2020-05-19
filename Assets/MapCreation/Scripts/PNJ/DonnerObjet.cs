using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DonnerObjet : MonoBehaviour
{

    public InventoryItem objet;
    public InventoryManager inventory;
    public GameObject recevoir;
    public TextMeshProUGUI nom;
    public TextMeshProUGUI description;
    public Image image;


    public void giveObject()
    {
        nom.text = objet.itemName;
        image.sprite = objet.itemImage;
        description.text = objet.itemDescription;
        recevoir.SetActive(true);
        inventory.addItem(objet);
    }
}
