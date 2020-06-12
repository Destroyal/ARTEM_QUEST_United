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

    public bool must_input;
    public bool has_input;

    public bool must_useless;
    public bool has_useless;

    public bool must_important;
    public bool has_important;

    public bool can_leave;
    public bool leave;

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

        must_input = false;
        has_input = false;

        must_useless = false;
        has_useless = false;

        must_important = false;
        has_important = false;

        can_leave = false;
        leave = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
