// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Primitives;

namespace SixLabors.ImageSharp.Processing.Processors
{
    /// <summary>
    /// Defines an algorithm to alter the pixels of an image.
    /// Non-generic <see cref="IImageProcessor"/> implementations are responsible for:
    /// 1. Encapsulating the parameters of the algorithm.
    /// 2. Creating the generic <see cref="IImageProcessor{TPixel}"/> instance to execute the algorithm.
    /// </summary>
    public interface IImageProcessor
    {
        /// <summary>
        /// Creates a pixel specific <see cref="IImageProcessor{TPixel}"/> that is capable for executing
        /// the processing algorithm on an <see cref="Image{TPixel}"/>.
        /// </summary>
        /// <typeparam name="TPixel">The pixel type.</typeparam>
        /// <param name="source">The source image. Cannot be null.</param>
        /// <param name="sourceRectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to draw.
        /// </param>
        /// <returns>The <see cref="IImageProcessor{TPixel}"/></returns>
        IImageProcessor<TPixel> CreatePixelSpecificProcessor<TPixel>(Image<TPixel> source, Rectangle sourceRectangle)
            where TPixel : struct, IPixel<TPixel>;
    }
}
