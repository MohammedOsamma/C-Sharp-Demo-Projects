﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Simple_Math_Expression_Evaluator
{
    public class MathExpression
    {
        public double LeftSideOperand { get; set; }
        public double RightSideOperand { get; set; }
        public MathOperation Operation { get; set; }
    }
}
