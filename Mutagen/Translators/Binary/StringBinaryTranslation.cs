﻿using Noggog;
using System;
using System.IO;
using System.Text;

namespace Mutagen.Binary
{
    public class StringBinaryTranslation : IBinaryTranslation<string, Exception>
    {
        public readonly static StringBinaryTranslation Instance = new StringBinaryTranslation();

        public TryGet<string> Parse(MutagenReader reader, ContentLength length, bool doMasks, out Exception errorMask)
        {
            try
            {
                errorMask = null;
                var str = Encoding.ASCII.GetString(reader.ReadBytes(length));
                str= str.TrimEnd('\0');
                return TryGet<string>.Succeed(str);
            }
            catch (Exception ex)
            {
                if (doMasks)
                {
                    errorMask = ex;
                    return TryGet<string>.Failure;
                }
                throw;
            }
        }

        public void Write(MutagenWriter writer, string item, bool nullTerminate, bool doMasks, out Exception errorMask)
        {
            try
            {
                writer.Write(item.ToCharArray());
                if (nullTerminate)
                {
                    writer.Write((byte)0);
                }
                errorMask = null;
            }
            catch (Exception ex)
            when (doMasks)
            {
                errorMask = ex;
            }
        }

        public void Write(MutagenWriter writer, string item, bool doMasks, out Exception errorMask)
        {
            Write(writer, item, doMasks: doMasks, nullTerminate: true, errorMask: out errorMask);
        }

        public void Write(
            MutagenWriter writer, 
            string item, 
            RecordType header,
            bool nullable,
            bool doMasks,
            out Exception errorMask)
        {
            try
            {
                if (item == null)
                {
                    if (nullable)
                    {
                        errorMask = null;
                        return;
                    }
                    throw new ArgumentException("Non optional string was null.");
                }
                using (HeaderExport.ExportHeader(writer, header, ObjectType.Subrecord))
                {
                    this.Write(writer, item, doMasks, out errorMask);
                }
            }
            catch (Exception ex)
            when (doMasks)
            {
                errorMask = ex;
            }
        }

        void IBinaryTranslation<string, Exception>.Write(MutagenWriter writer, string item, ContentLength length, bool doMasks, out Exception maskObj)
        {
            if (length != item.Length)
            {
                var ex = new ArgumentException($"Expected length was {item.Length}, but was passed {length}.");
                if (doMasks)
                {
                    maskObj = ex;
                    return;
                }
                throw ex;
            }
            Write(writer, item, doMasks, out maskObj);
        }
    }
}
