using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PnjState
{
    idle,
    speaking
}

public class PNJ : MonoBehaviour
{
    public GameObject Notif;
    public string Name;
    public Dialog dialog;
    public bool donneur;
    private Animator anim;
    private bool playerInRange;
    private DialogManager dialogManager;
    private PnjState currentState;
    private GameObject player;
    public DonnerObjet donnerObjet;
    public InventoryItem item;

    private void Start()
    {
        currentState = PnjState.idle;
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        dialogManager = GetComponent<DialogManager>();
        if(donnerObjet == null)
        {
            donneur = false;
        }
        else
        {
            donnerObjet.objet = item;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if(currentState == PnjState.idle)
            {
                player.GetComponent<PlayerMovement>().currentState = PlayerState.speaking;
                dialogManager.StartDialog(dialog,Name);
                Notif.SetActive(false);
                anim.SetBool("Speaking", true);
                currentState = PnjState.speaking;
            }
            else
            {
                dialogManager.ContinueDialog();
                if (dialogManager.DialogEnded && donneur)
                {
                    donnerObjet.giveObject();
                    donneur = false;
                }
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().currentState = PlayerState.interact;
            playerInRange = true;
            if (Notif != null)
            {
                Notif.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().currentState = PlayerState.walk;
            playerInRange = false;
            if (Notif != null)
            {
                Notif.SetActive(false);
            }
            currentState = PnjState.idle;
            anim.SetBool("Speaking", false);
        }
    }

}
