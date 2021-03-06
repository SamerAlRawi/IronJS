// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.RelationalOperators
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheInOperatorTests : SputnikTestFixture
    {
        public TheInOperatorTests()
            : base(@"Conformance\11_Expressions\11.8_Relational_Operators\11.8.7_The_in_operator")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.8.7")]
        [Category("ECMA 7.2")]
        [Category("ECMA 7.3")]
        [TestCase("S11.8.7_A1.js", Description = "White Space and Line Terminator between RelationalExpression and \"in\" and between \"in\" and ShiftExpression are allowed")]
        public void WhiteSpaceAndLineTerminatorBetweenRelationalExpressionAndInAndBetweenInAndShiftExpressionAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.8.7")]
        [TestCase("S11.8.7_A2.1_T1.js", Description = "Operator \"in\" uses GetValue")]
        [TestCase("S11.8.7_A2.1_T2.js", Description = "Operator \"in\" uses GetValue")]
        [TestCase("S11.8.7_A2.1_T3.js", Description = "Operator \"in\" uses GetValue")]
        public void OperatorInUsesGetValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.8.7")]
        [TestCase("S11.8.7_A2.4_T1.js", Description = "First expression is evaluated first, and then second expression")]
        [TestCase("S11.8.7_A2.4_T2.js", Description = "First expression is evaluated first, and then second expression")]
        [TestCase("S11.8.7_A2.4_T3.js", Description = "First expression is evaluated first, and then second expression")]
        public void FirstExpressionIsEvaluatedFirstAndThenSecondExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.8.7")]
        [TestCase("S11.8.7_A3.js", Description = "If ShiftExpression is not an object, throw TypeError")]
        public void IfShiftExpressionIsNotAnObjectThrowTypeError(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.8.7")]
        [Category("ECMA 9.8")]
        [TestCase("S11.8.7_A4.js", Description = "Operator \"in\" calls ToString(ShiftExpression)")]
        public void OperatorInCallsToStringShiftExpression(string file)
        {
            RunFile(file);
        }
    }
}