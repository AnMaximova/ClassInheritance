using System;

namespace ClassInheritance
{
    public abstract class HeirArray
    {
        public  HeirArray(int row, int column = 0,bool input_mode = false)
        {
            if (input_mode) 
            {
                InputUser(row,column);
            }
            else 
            {
                InputRandom(row,column);
            }
        }
        private protected abstract void InputUser(int row, int column = 0);
        private protected abstract void InputRandom(int row, int column = 0);
        public abstract void OutArr();
        public abstract float Average();
    }
}
