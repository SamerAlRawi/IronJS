﻿using System;
using System.Text;
using Antlr.Runtime.Tree;
using Et = System.Linq.Expressions.Expression;

namespace IronJS.Compiler.Ast
{
    public class AssignNode : Node, INode
    {
        public INode Target { get; protected set; }
        public INode Value { get; protected set; }

        public AssignNode(INode target, INode value, ITree node)
            : base(NodeType.Assign, node)
        {
            Target = target;
            Value = value;
        }

        public override INode Analyze(IjsAstAnalyzer astopt)
        {
            Target = Target.Analyze(astopt);
            Value = Value.Analyze(astopt);

            var idNode = (Target as IdentifierNode);
            if (idNode != null && idNode.IsLocal)
                idNode.VarInfo.AssignedFrom.Add(Value);

            return this;
        }

        public override Et EtGen(IjsEtGenerator etgen)
        {
            return etgen.GenAssignEt(Target, Value);
        }

        public override Et Generate(EtGenerator etgen)
        {
            return etgen.GenerateAssign(
                Target,
                Value.Generate(etgen)
            );
        }

        public override void Print(StringBuilder writer, int indent = 0)
        {
            var indentStr = new String(' ', indent * 2);

            writer.AppendLine(indentStr + "(" + NodeType + " ");

            Target.Print(writer, indent + 1);
            Value.Print(writer, indent + 1);

            writer.AppendLine(indentStr + ")");
        }
    }
}
