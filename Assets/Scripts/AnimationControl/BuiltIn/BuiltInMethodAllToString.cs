using OALProgramControl;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.AnimationControl.BuiltIn
{
    public class BuiltInMethodAllToString : BuiltInMethodBase
    {
        public override EXEExecutionResult Evaluate(EXEValueBase owningObject, List<EXEValueBase> parameters)
        {
            string stringValue;
            try
            {
                VisitorCommandToString visitor = new VisitorCommandToString();
                owningObject.Accept(visitor);
                stringValue = visitor.GetCommandString();
                stringValue = $"\"{stringValue}\"";
            }
            catch (Exception e)
            {
                return EXEExecutionResult.Error("XEC2059", string.Format($"Failed to convert value to string because {e.Message}."));
            }

            EXEExecutionResult result = EXEExecutionResult.Success();
            result.ReturnedOutput = new EXEValueString(stringValue);
            return result;
        }
    }
}