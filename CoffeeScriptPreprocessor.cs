using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using CoffeeSharp;
using Piedone.Combinator.EventHandlers;

namespace Piedone.Combinator.CoffeeScript {
    public class CoffeeScriptPreprocessor : ICombinatorResourceEventHandler
    {

        public void OnContentLoaded(Models.CombinatorResource resource)
        {
            if (Path.GetExtension(resource.AbsoluteUrl.ToString()).ToLowerInvariant() != ".coffee") return;

            resource.Content = new CoffeeScriptEngine().Compile(resource.Content);
        }

        public void OnContentProcessed(Models.CombinatorResource resource)
        {
        }
    }
}