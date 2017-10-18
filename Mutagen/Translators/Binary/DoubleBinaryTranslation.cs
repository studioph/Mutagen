﻿using Noggog;
using System;
using System.IO;

namespace Mutagen.Binary
{
    public class DoubleBinaryTranslation : PrimitiveBinaryTranslation<double>
    {
        public readonly static DoubleBinaryTranslation Instance = new DoubleBinaryTranslation();
        public override byte? ExpectedLength => 4;

        protected override double ParseValue(MutagenReader reader)
        {
            return reader.ReadDouble();
        }

        protected override void WriteValue(MutagenWriter writer, double item)
        {
            writer.Write(item);
        }
    }
}
