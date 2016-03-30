using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Program.AI
{
    public class HeroInfoDisplay : MonoBehaviour,IVelocityChange,ILifeChange
    {
        public Text Life;
        public Text Velocity;
        
        void Awake()
        {
            EventManager.GetInstance().ListenVelocityChange(this);
            EventManager.GetInstance().ListenLifeChange(this);
        }

        public void OnVelocityChange(int id, float velocity)
        {
            Velocity.text = velocity.ToString();
        }

        public void OnLifeChange(int id, float life)
        {
            Life.text = life.ToString();
        }
    }
}
