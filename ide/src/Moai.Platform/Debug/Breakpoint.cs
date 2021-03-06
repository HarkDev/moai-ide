﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moai.Platform.Debug;

namespace Moai.Platform.Debug
{
    public class Breakpoint : IBreakpoint
    {
        private string p_SourceFile;
        private uint p_SourceLine;

        /// <summary>
        /// Creates a new Breakpoint object that represents a debugging
        /// breakpoint.
        /// </summary>
        /// <param name="file">The file which the breakpoint should be placed in.</param>
        /// <param name="line">The line number on which to break.</param>
        public Breakpoint(string file, uint line)
        {
            this.p_SourceFile = file;
            this.p_SourceLine = line;
        }

        /// <summary>
        /// The file which the breakpoint is associated with.
        /// </summary>
        public string SourceFile
        {
            get
            {
                return this.p_SourceFile;
            }
        }

        /// <summary>
        /// The line on which this breakpoint will be triggered.
        /// </summary>
        public uint SourceLine
        {
            get
            {
                return this.p_SourceLine;
            }
        }
    }
}
