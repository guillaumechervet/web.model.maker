using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateDesigner
{
    using Antlr4.StringTemplate;
    using Antlr4.StringTemplate.Misc;

    public class ErrorListener : ITemplateErrorListener
    {

        private readonly IList<TemplateMessage> templateMessages = new List<TemplateMessage>(); 

        public void CompiletimeError(TemplateMessage msg)
        {
            
            templateMessages.Add(msg);
        }

        public void RuntimeError(TemplateMessage msg)
        {
            templateMessages.Add(msg);

        }

        public void IOError(TemplateMessage msg)
        {
            templateMessages.Add(msg);

        }

        public void InternalError(TemplateMessage msg)
        {
            templateMessages.Add(msg);
        }
    }
}
