﻿using LanguageExt.TypeClasses;
using System.Collections.Generic;
using static LanguageExt.Prelude;
using System;

namespace LanguageExt.Instances
{
    /// <summary>
    /// Uses the standard .NET  Comparer<A>.Default.Compare(a,b) method to
    /// provide equality testing.
    /// </summary>
    public struct OrdDefault<A> : Ord<A>
    {
        /// <summary>
        /// Equality test
        /// </summary>
        /// <param name="x">The left hand side of the equality operation</param>
        /// <param name="y">The right hand side of the equality operation</param>
        /// <returns>True if x and y are equal</returns>
        public int Compare(A x, A y) =>
            Comparer<A>.Default.Compare(x, y);

        public bool Equals(A x, A y) =>
            default(EqDefault<A>).Equals(x, y);
    }
}