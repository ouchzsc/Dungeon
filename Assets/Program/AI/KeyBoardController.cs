using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Program.AI
{
    public class KeyBoardController:MonoBehaviour
    {
        bool isFrozen = false;
        HeroModule heroModule;

        void Start()
        {
            heroModule = GetComponent<HeroModule>();
        }
        void Update()
        {            
            if(Input.GetKey(KeyCode.DownArrow))
            {
                Walk(0, -1);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                Walk(0, 1);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                Walk(-1,0);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
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

            StartCoroutine(Freeze(1/heroModule.velocity));
        }
        IEnumerator Freeze(float time)
        {
            yield return new WaitForSeconds(time);
            isFrozen = false;
        }
    }
}
