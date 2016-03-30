using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Program
{
    public class EventManager
    {
        private static EventManager instantce = null;
        public static EventManager GetInstance()
        {
            if (instantce == null)
                instantce = new EventManager();
            return instantce;
        }

        ///--------------------------------------------------
        ///Velocity
        private List<IVelocityChange> VelocityChangeListners = new List<IVelocityChange>();
        public void ListenVelocityChange(IVelocityChange listener)
        {
            if (!VelocityChangeListners.Contains(listener))
                VelocityChangeListners.Add(listener);
        }
        public void UnListenVelocityChange(IVelocityChange listener)
        {
            if (VelocityChangeListners.Contains(listener))
                VelocityChangeListners.Remove(listener);
        }
        public void OnVelocityChange(int id,float velocity)
        {
            foreach (var item in VelocityChangeListners)
            {
                item.OnVelocityChange(id,velocity);
            }
        }

        ///--------------------------------------------------
        ///Life
        private List<ILifeChange> LifeChangeListeners = new List<ILifeChange>();
        public void ListenLifeChange(ILifeChange listener)
        {
            if (!LifeChangeListeners.Contains(listener))
                LifeChangeListeners.Add(listener);
        }
        public void UnListenLifeChange(ILifeChange listener)
        {
            if (LifeChangeListeners.Contains(listener))
                LifeChangeListeners.Remove(listener);
        }
        public void OnLifeChange(int id,float velocity)
        {
            foreach (var item in LifeChangeListeners)
            {
                item.OnLifeChange(id, velocity);
            }
        }
        
    }
}
