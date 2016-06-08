// Copyright (c) Terence Parr, Sam Harwell. All Rights Reserved.
// Licensed under the BSD License. See LICENSE.txt in the project root for license information.

/*
* [The "BSD license"]
*  Copyright (c) 2012 Terence Parr
*  Copyright (c) 2012 Sam Harwell
*  All rights reserved.
*
*  Redistribution and use in source and binary forms, with or without
*  modification, are permitted provided that the following conditions
*  are met:
*
*  1. Redistributions of source code must retain the above copyright
*     notice, this list of conditions and the following disclaimer.
*  2. Redistributions in binary form must reproduce the above copyright
*     notice, this list of conditions and the following disclaimer in the
*     documentation and/or other materials provided with the distribution.
*  3. The name of the author may not be used to endorse or promote products
*     derived from this software without specific prior written permission.
*
*  THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY EXPRESS OR
*  IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
*  OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
*  IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT, INDIRECT,
*  INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
*  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
*  DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
*  THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
*  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
*  THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
using Antlr4.Runtime.Sharpen;

namespace Antlr4.Runtime.Tree
{
    /// <summary>This interface defines the basic notion of a parse tree visitor.</summary>
    /// <remarks>
    /// This interface defines the basic notion of a parse tree visitor. Generated
    /// visitors implement this interface and the
    /// <c>XVisitor</c>
    /// interface for
    /// grammar
    /// <c>X</c>
    /// .
    /// </remarks>
    /// <author>Sam Harwell</author>
    /// <?/>
    public interface IParseTreeVisitor<Result>
    {
        /// <summary>Visit a parse tree, and return a user-defined result of the operation.</summary>
        /// <param name="tree">
        /// The
        /// <see cref="IParseTree"/>
        /// to visit.
        /// </param>
        /// <returns>The result of visiting the parse tree.</returns>
        Result Visit(IParseTree tree);

        /// <summary>
        /// Visit the children of a node, and return a user-defined result
        /// of the operation.
        /// </summary>
        /// <param name="node">
        /// The
        /// <see cref="IRuleNode"/>
        /// whose children should be visited.
        /// </param>
        /// <returns>The result of visiting the children of the node.</returns>
        Result VisitChildren(IRuleNode node);

        /// <summary>Visit a terminal node, and return a user-defined result of the operation.</summary>
        /// <param name="node">
        /// The
        /// <see cref="ITerminalNode"/>
        /// to visit.
        /// </param>
        /// <returns>The result of visiting the node.</returns>
        Result VisitTerminal(ITerminalNode node);

        /// <summary>Visit an error node, and return a user-defined result of the operation.</summary>
        /// <param name="node">
        /// The
        /// <see cref="IErrorNode"/>
        /// to visit.
        /// </param>
        /// <returns>The result of visiting the node.</returns>
        Result VisitErrorNode(IErrorNode node);
    }
}
