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
        private protected abstract void InputUser();
        private protected abstract void InputRandom();
        public abstract void OutArr();
        public abstract float Average();
    }
}
