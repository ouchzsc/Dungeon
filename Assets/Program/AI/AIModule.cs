using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Program.AI
{
    public class AIModule:MonoBehaviour
    {
        [SerializeField,SetProperty("Velocity")]
        private float velocity;
        public float Velocity
        {
            get
            {
                return velocity;
            }
            set
            {
                velocity = value;
                EventManager.GetInstance().OnVelocityChange(id,velocity);
            }
        }


        [SerializeField, SetProperty("Velocity")]
        private int id = 0;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        [SerializeField, SetProperty("Velocity")]
        private float life;
        public float Life
        {
            get
            {
                return life;
            }
            set
            {
                life = value;
                EventManager.GetInstance().OnLifeChange(id, life);
            }
        }

        void Start()
        {
            Velocity = 1 / constants.KeyBoardControllFreezeTime;
            Life = constants.heroInitLife;
        }

    }
}
