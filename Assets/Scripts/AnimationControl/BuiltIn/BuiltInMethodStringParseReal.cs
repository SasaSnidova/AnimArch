using OALProgramControl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Scripts.AnimationControl.BuiltIn
{
    internal class BuiltInMethodStringParseReal : BuiltInMethodString
    {
        protected override EXEExecutionResult Evaluate(EXEValueString owningObject, List<EXEValueBase> parameters)
        {
            decimal parsedReal;
            if (!decimal.TryParse(owningObject.Value, out parsedReal))
            {
                parsedReal = 0;
            }

            EXEExecutionResult result = EXEExecutionResult.Success();
            result.ReturnedOutput = new EXEValueReal(parsedReal);
            return result;
        }
    }
}
