﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lundeen_linkedlist
{
    class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
        public Node (string d)
        {
            Data = d;
        }


    }
}
