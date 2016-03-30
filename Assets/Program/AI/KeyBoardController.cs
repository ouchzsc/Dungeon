using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Program.AI
{
    public class KeyBoardController:MonoBehaviour
    {
        bool isFrozen = false;
        AIModule heroModule;

        void Start()
        {
            heroModule = GetComponent<AIModule>();
        }
        void Update()
        {            
            if(Input.GetAxis("Vertical")<0)
            {
                Walk(0, -1);
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                Walk(0, 1);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                Walk(-1,0);
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                Walk(1,0);
            }
        }
        void Walk(int x, int y)
        {
            if (isFrozen)
                return;
            isFrozen = true;

            transform.position += new Vector3(x, y);

            StartCoroutine(Freeze(1/heroModule.Velocity));
        }
        IEnumerator Freeze(float time)
        {
            yield return new WaitForSeconds(time);
            isFrozen = false;
        }
    }
}
