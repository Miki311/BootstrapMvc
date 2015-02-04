﻿using System;
using BootstrapMvc.Core;

namespace BootstrapMvc.Lists
{
    public class DefinitionListContent : DisposableContext
    {
        public DefinitionListContent(IBootstrapContext context)
            : base(context)
        {
            // Nothing
        }

        public AnyContentElement Name(object content)
        {
            return new OrdinaryElement(Context, "dt").Content(content);
        }

        public new AnyContentElement Value(object content)
        {
            return new OrdinaryElement(Context, "dd").Content(content);
        }

        public AnyContentElement Value(params object[] contents)
        {
            return new OrdinaryElement(Context, "dd").Content(contents);
        }
    }
}
