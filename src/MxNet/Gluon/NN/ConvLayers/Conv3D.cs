﻿namespace MxNet.Gluon.NN
{
    public class Conv3D : _Conv
    {
        public Conv3D(int channels, (int, int, int) kernel_size, (int, int, int)? strides = null,
            (int, int, int)? padding = null,
            (int, int, int)? dilation = null, int groups = 1, string layout = "NCDHW", int in_channels = 0,
            ActivationType? activation = null, bool use_bias = true, string weight_initializer = null,
            string bias_initializer = "zeros", string prefix = null, ParameterDict @params = null)
            : base(channels, new[] {kernel_size.Item1, kernel_size.Item2, kernel_size.Item3},
                !strides.HasValue ? new[] {1, 1, 1} : new[] {strides.Value.Item1, strides.Value.Item2, strides.Value.Item3},
                !padding.HasValue ? new[] {0, 0, 0} : new[] {padding.Value.Item1, padding.Value.Item2, padding.Value.Item3},
                !dilation.HasValue ? new[] {1, 1, 1} : new[] {dilation.Value.Item1, dilation.Value.Item2, dilation.Value.Item3},
                groups, layout, in_channels, activation, use_bias,
                weight_initializer, bias_initializer, null, "Convolution", prefix, @params)
        {
        }
    }
}