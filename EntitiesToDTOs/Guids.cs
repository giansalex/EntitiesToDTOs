// Guids.cs
// MUST match guids.h
using System;

namespace IMM.EntitiesToDTOs
{
    static class GuidList
    {
        public const string guidEntitiesToDTOsPkgString = "f28519e8-752b-4790-b2ef-66cd3028358a";
        public const string guidEntitiesToDTOsCmdSetString = "88cf2600-b81a-4f2b-803a-ae17702a1414";

        public static readonly Guid guidEntitiesToDTOsCmdSet = new Guid(guidEntitiesToDTOsCmdSetString);
    };
}