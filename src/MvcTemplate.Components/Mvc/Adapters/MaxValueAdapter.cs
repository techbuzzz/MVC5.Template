﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcTemplate.Components.Mvc
{
    public class MaxValueAdapter : DataAnnotationsModelValidator<MaxValueAttribute>
    {
        public MaxValueAdapter(ModelMetadata metadata, ControllerContext context, MaxValueAttribute attribute)
            : base(metadata, context, attribute)
        {
        }

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
        {
            ModelClientValidationRule rule = new ModelClientValidationRule();
            rule.ValidationParameters.Add("max", Attribute.Maximum);
            rule.ErrorMessage = ErrorMessage;
            rule.ValidationType = "range";

            return new[] { rule };
        }
    }
}
