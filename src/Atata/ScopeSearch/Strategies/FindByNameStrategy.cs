﻿using Humanizer;
using System.Text;

namespace Atata
{
    public class FindByNameStrategy : XPathComponentScopeLocateStrategy
    {
        public FindByNameStrategy()
            : base(applyIndex: false)
        {
        }

        protected override void BuildXPath(StringBuilder builder, ComponentScopeLocateOptions options)
        {
            string nameCondition = options.GetTermsXPathCondition("@name");

            builder.Insert(0, "*[{0}]{1}/descendant-or-self::".FormatWith(nameCondition, options.GetPositionWrappedXPathCondition()));
        }
    }
}