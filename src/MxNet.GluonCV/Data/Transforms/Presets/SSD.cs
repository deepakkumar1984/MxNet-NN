﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MxNet.GluonCV.Data.Transforms.Presets
{
    public class SSD
    {
        public static (NDArrayList, string[]) TransformTest(NDArrayList imgs, int @short, int max_size = 1024, (float, float, float)? mean = null, (float, float, float)? std = null)
        {
            throw new NotImplementedException();
        }

        public static (NDArrayList, string[]) LoadTest(string[] filenames, int @short, int max_size = 1024, (float, float, float)? mean = null, (float, float, float)? std = null)
        {
            throw new NotImplementedException();
        }
    }
}
