﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    /// <summary>
    /// A node in scene that maintains some <see cref="GLState"/>s.
    /// </summary>
    public class GLStateNode : SceneNode
    {
        private List<IGLState> stateList = new List<IGLState>();

        /// <summary>
        /// 
        /// </summary>
        public IList<IGLState> StateList { get { return this.stateList; } }

    }

}