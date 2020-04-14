using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalAchievement : MonoBehaviour
{
    public bool must_walk;
    public bool has_walked;

    public bool must_first_dialog;
    public bool first_dialog;
    public bool has_passed_dialog;
    public bool has_finished_dialog;

    public bool must_interact;
    public bool is_interacting;
    public bool has_interacted;

    public bool must_click;
    public bool has_clicked;

    // Start is called before the first frame update
    void Start()
    {
        must_walk = true;
        has_walked = false;

        must_first_dialog = false;
        first_dialog = false;
        has_passed_dialog = false;
        has_finished_dialog = false;

        must_interact = false;
        is_interacting = false;
        has_interacted = false;

        must_click = false;
        has_clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
