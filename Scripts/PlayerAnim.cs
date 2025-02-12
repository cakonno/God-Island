using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour

{
    private Player player;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        OnMove();
        OnRun();
        OnCutting();

    }

   #region Moviment

    void OnMove()
    {
        if (player.direction.sqrMagnitude > 0)
        {
            anim.SetInteger("Transition", 1);

            if (player.isRolling)
            {
                anim.SetTrigger("isRolling");
            }
        }
        else
        {
            anim.SetInteger("Transition", 0);
        }

        if (player.direction.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);

        }
        if (player.direction.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);

        }
    }


    void OnRun()
    {
        if (player.isRunning)
        {
            anim.SetInteger("Transition", 2);
        }
    }

    void OnCutting()
    {
        if (player.isCutting)
        {
            anim.SetInteger ("Transition", 4);
        }
    }


 #endregion
}
