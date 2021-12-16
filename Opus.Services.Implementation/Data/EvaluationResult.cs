﻿using Opus.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opus.Services.Implementation.Data
{
    public class EvaluationResult : IFileEvaluationResult
    {
        public OutcomeType Outcome { get; }
        public string? FilePath { get; }
        public string? Name { get; }

        private EvaluationResult(OutcomeType outcome, string? filePath, string? name)
        {
            Outcome = outcome;
            FilePath = filePath;
            Name = name;
        }

        public static IFileEvaluationResult Match(string filePath, string name)
        {
            return new EvaluationResult(OutcomeType.Match, filePath, name);
        }
        public static IFileEvaluationResult NoMatch()
        {
            return new EvaluationResult(OutcomeType.NoMatch, null, null);
        }
    }
}
