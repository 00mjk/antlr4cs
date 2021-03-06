// Copyright (c) Terence Parr, Sam Harwell. All Rights Reserved.
// Licensed under the BSD License. See LICENSE.txt in the project root for license information.

using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Sharpen;

namespace Antlr4.Runtime.Atn
{
    /// <summary>
    /// This class represents profiling event information for semantic predicate
    /// evaluations which occur during prediction.
    /// </summary>
    /// <seealso cref="ParserATNSimulator.EvalSemanticContext(Antlr4.Runtime.Dfa.DFAState.PredPrediction[], Antlr4.Runtime.ParserRuleContext, bool)"/>
    /// <since>4.3</since>
    public class PredicateEvalInfo : DecisionEventInfo
    {
        /// <summary>The semantic context which was evaluated.</summary>
        public readonly SemanticContext semctx;

        /// <summary>
        /// The alternative number for the decision which is guarded by the semantic
        /// context
        /// <see cref="semctx"/>
        /// . Note that other ATN
        /// configurations may predict the same alternative which are guarded by
        /// other semantic contexts and/or
        /// <see cref="SemanticContext.None"/>
        /// .
        /// </summary>
        public readonly int predictedAlt;

        /// <summary>
        /// The result of evaluating the semantic context
        /// <see cref="semctx"/>
        /// .
        /// </summary>
        public readonly bool evalResult;

        /// <summary>
        /// Constructs a new instance of the
        /// <see cref="PredicateEvalInfo"/>
        /// class with the
        /// specified detailed predicate evaluation information.
        /// </summary>
        /// <param name="state">The simulator state</param>
        /// <param name="decision">The decision number</param>
        /// <param name="input">The input token stream</param>
        /// <param name="startIndex">The start index for the current prediction</param>
        /// <param name="stopIndex">
        /// The index at which the predicate evaluation was
        /// triggered. Note that the input stream may be reset to other positions for
        /// the actual evaluation of individual predicates.
        /// </param>
        /// <param name="semctx">The semantic context which was evaluated</param>
        /// <param name="evalResult">The results of evaluating the semantic context</param>
        /// <param name="predictedAlt">
        /// The alternative number for the decision which is
        /// guarded by the semantic context
        /// <paramref name="semctx"/>
        /// . See
        /// <see cref="predictedAlt"/>
        /// for more information.
        /// </param>
        /// <seealso cref="ParserATNSimulator.EvalSemanticContext(SemanticContext, ParserRuleContext, int)"/>
        /// <seealso cref="SemanticContext.Eval"/>
        public PredicateEvalInfo([NotNull] SimulatorState state, int decision, [NotNull] ITokenStream input, int startIndex, int stopIndex, [NotNull] SemanticContext semctx, bool evalResult, int predictedAlt)
            : base(decision, state, input, startIndex, stopIndex, state.useContext)
        {
            this.semctx = semctx;
            this.evalResult = evalResult;
            this.predictedAlt = predictedAlt;
        }
    }
}
