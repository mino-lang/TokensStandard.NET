using System;
using System.Collections.Generic;
using System.Text;

namespace TokensStandart
{
    public sealed class Lambda<T>
    {
        public List<Type> types = new List<Type>();

        private bool Valid(object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].GetType() != types[i]) return false;
            }
            return true;
        }

        //public T Run()
        //{
            //pass
        //}
    }
}
