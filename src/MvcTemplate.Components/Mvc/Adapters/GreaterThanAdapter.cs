﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcTemplate.Components.Mvc
{
    public class GreaterThanAdapter : DataAnnotationsModelValidator<GreaterThanAttribute>
    {
        public GreaterThanAdapter(ModelMetadata metadata, ControllerContext context, GreaterThanAttribute attribute)
            : base(metadata, context, attribute)
        {
        }

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
        {
            ModelClientValidationRule rule = new ModelClientValidationRule();
            rule.ValidationParameters.Add("min", Attribute.Minimum);
            rule.ErrorMessage = ErrorMessage;
            rule.ValidationType = "greater";

            return new[] { rule };
        }
    }
}
