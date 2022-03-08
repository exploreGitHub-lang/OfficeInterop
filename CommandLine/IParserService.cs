﻿namespace CommandLineParser
{
    public enum ExitCode
    {
        OK,
        Stop,
        Error = -1
    }

    public interface IParserService
    {
        ExitCode ParseInput(string input);
    }

    public class ValidFilenameDto
    {
        public string IllegalString { get; set; }
        public bool Valid { get; set; }
    }
}
