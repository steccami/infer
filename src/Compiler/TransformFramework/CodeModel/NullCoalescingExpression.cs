// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.ML.Probabilistic.Compiler.CodeModel;

namespace Microsoft.ML.Probabilistic.Compiler.CodeModel.Concrete
{
    internal class XNullCoalescingExpression : XExpression, INullCoalescingExpression
    {
        public IExpression Condition { get; set; }
        public IExpression Expression { get; set; }

        public override Type GetExpressionType()
        {
            return Expression.GetExpressionType();
        }
    }
}
