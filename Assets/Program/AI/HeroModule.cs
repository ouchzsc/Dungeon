using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Program.AI
{
    public class HeroModule:MonoBehaviour
    {
        public float velocity;
        void Start()
        {
            velocity = constants.KeyBoardControllFreezeTime;
        }
    }
}
