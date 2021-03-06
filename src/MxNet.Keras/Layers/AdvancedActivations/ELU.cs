﻿using MxNet.Keras.Engine;
using System;
using System.Collections.Generic;
using System.Text;
using K = MxNet.Keras.MxNetBackend;

namespace MxNet.Keras.Layers.AdvancedActivations
{
    public class ELU : Layer
    {
        public float alpha;

        public ELU(float alpha = 0.3f) : base()
        {
            this.supports_masking = true;
            this.alpha = alpha;
        }

        public override KerasSymbol[] Invoke(KerasSymbol[] inputs, FuncArgs kwargs = null)
        {
            List<KerasSymbol> result = new List<KerasSymbol>();
            foreach (var input in inputs)
            {
                result.Add(K.Elu(input, alpha));
            }

            return result.ToArray();
        }

        public override ConfigDict GetConfig()
        {
            var config = new ConfigDict {
                    {
                        "alpha",
                        this.alpha}};
            var base_config = base.GetConfig();
            base_config.Update(config);
            return base_config;
        }

        public override Shape[] ComputeOutputShape(Shape[] input_shape)
        {
            return input_shape;
        }
    }
}
