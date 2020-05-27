﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Iterator : IAbstractIterator
    {
        private Box box;
        private int currentPosition;

        public Iterator(Box box)
        {
            this.box = box;
            this.currentPosition = 0;
        }
        

        public Product Current
        {
            get
            {
                return this.box[this.currentPosition];
            }
        }

        public bool IsDone
        {
            get
            {
                return this.currentPosition >= this.box.Count;
            }
        }

        public Product First()
        {
            return this.box[0];
        }

        public Product Next()
        {
            this.currentPosition++;
            if (this.IsDone)
            {
                return null;
            }
            else {
                return this.box[this.currentPosition];
            }
        }
    }
}
