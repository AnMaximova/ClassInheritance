using System;

namespace ClassInheritance
{
    public abstract class HeirArray
    {
        public  HeirArray(bool input_mode = false)
        {
            if (input_mode) 
            {
                InputUser();
            }
            else 
            {
                InputRandom();
            }
        }
        internal abstract void InputUser();
        internal abstract void InputRandom();
        public abstract void OutArr();
        public abstract float Average();
    }
}
