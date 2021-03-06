// <copyright file="ITranscriptionProcessor.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace TeamsTranscript.Cli.Parsers
{
    public interface ITranscriptionProcessor
    {
        IEnumerable<Transcription> Aggregate(IEnumerable<Transcription> transcripts);
    }
}