﻿/* EntitiesToDTOs. Copyright (c) 2011. Fabian Fernandez.
 * http://entitiestodtos.codeplex.com
 * Licensed by Common Development and Distribution License (CDDL).
 * http://entitiestodtos.codeplex.com/license
 * Fabian Fernandez. 
 * http://www.linkedin.com/in/fabianfernandezb/en
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesToDTOs.Domain
{
    /// <summary>
    /// Represents a depedency of a Source Code namespace.
    /// </summary>
    internal class SourceCodeImport
    {
        /// <summary>
        /// Import Namespace.
        /// </summary>
        public string ImportNamespace { get; private set; }


        public SourceCodeImport(string importNamespace)
        {
            this.ImportNamespace = importNamespace;
        }
    }
}