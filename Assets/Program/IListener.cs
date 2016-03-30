using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Program
{
    public interface IVelocityChange
    {
        void OnVelocityChange(int id,float velocity);
    }

    public interface ILifeChange
    {
        void OnLifeChange(int id,float life);
    }
}
