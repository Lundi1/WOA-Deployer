﻿namespace Deployer.Tests
{
    public class Requirement
    {
        public Requirement(string variableName, string kind, string value)
        {
            VariableName = variableName;
            Kind = kind;
            Value = value;
        }

        public string VariableName { get; }
        public string Kind { get; }
        public string Value { get; }
    }
}