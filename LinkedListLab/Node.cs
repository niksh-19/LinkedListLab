﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLab
{
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }

        public Node(string value)
        {
            Value = value;
            Next = null;
        }
    }
}
