﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swspl.nso
{
    public class NSOSegment
    {
        public NSOSegment(BinaryReader reader)
        {
            mOffset = reader.ReadUInt32();
            mMemOffset = reader.ReadUInt32();
            mSize = reader.ReadInt32();
        }

        public uint GetOffset()
        {
            return mOffset;
        }

        public uint GetMemoryOffset()
        {
            return mMemOffset;
        }

        public int GetSize()
        {
            return mSize;
        }

        public bool IsInRange(uint offs)
        {
            return (offs >= mMemOffset) && (offs <= mMemOffset + mSize);
        }

        uint mOffset;
        uint mMemOffset;
        int mSize;
    }
}
