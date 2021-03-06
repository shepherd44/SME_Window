﻿using DumpReader.Native;
using System;

namespace DumpReader.MinidumpStream
{
    //Breakpad에서 제공하는 BreakpadInfo Stream 구조체를 읽기위한 클래스
    [Serializable]
    public class MiniDumpBreakpadInfo
    {
        private MDRawBreakpadInfo m_breakpadInfo;
        
        internal MiniDumpBreakpadInfo(MDRawBreakpadInfo breakpadInfo)
        {
            m_breakpadInfo = breakpadInfo;
        }

        public UInt32 validate { get { return m_breakpadInfo.validity; } }
        public UInt32 dumpThreadId { get { return m_breakpadInfo.dump_thread_id; } }
        public UInt32 requestThreadId { get { return m_breakpadInfo.requesting_thread_id; } }
    }
}
