﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class InvertParameters : IParameters
    {

        public ParameterInfo[] GetDisciption()
        {
            return new[]
            {
                new ParameterInfo()
                {
                }
            };
        }

        public void SetValues(double[] values)
        {
        }
    }
}